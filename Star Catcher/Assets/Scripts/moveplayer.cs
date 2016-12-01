using UnityEngine;
using System.Collections;

public class moveplayer: MonoBehaviour
{
	private CharacterController myCC;
	private Animator myAnimate;
	private SpriteRenderer BunnyArt;
	private Vector3 tempPos;
	public float speed = 30.0f;
	private float gravity = 4f;
	public float jumpSpeed = 45.0f;
	public int jumpCountMax = 1;
	public int slideDuration = 100;
	public float slideTime = 0.1f;
	public bool InMud=false;
	public bool Grounded = true;




	void Start ()
	{
		BunnyArt = GetComponent<SpriteRenderer> ();
		myAnimate = GetComponent<Animator> ();
		myCC = GetComponent<CharacterController> ();
		mud.Entermud += EntermudHandler;
		HurtBunny.BunnyHit += BunnyDamageHandler;

	}
	void OnDestroy(){
		HurtBunny.BunnyHit -= BunnyDamageHandler;
	}
	void BunnyDamageHandler(HurtBunny obj)
	{
		
		StartCoroutine (DamageBlink ());
	}
	IEnumerator DamageBlink()
	{
		BunnyArt.enabled = false;
			yield return new WaitForSeconds(0.1f);
		BunnyArt.enabled = true;
		yield return new WaitForSeconds (0.1f);
		BunnyArt.enabled = false;
		yield return new WaitForSeconds (0.1f);
		BunnyArt.enabled = true;
		yield return new WaitForSeconds (0.1f);
		BunnyArt.enabled = false;
		yield return new WaitForSeconds(0.1f);
		BunnyArt.enabled = true;
		yield return new WaitForSeconds (0.1f);
		BunnyArt.enabled = false;
		yield return new WaitForSeconds (0.1f);
		BunnyArt.enabled = true;
	}

	IEnumerator Slide ()
	{
		int durationTemp = slideDuration;
		float speedTemp = speed;
		speed += speed;

		while (slideDuration > 0)
		{
			slideDuration--;
			yield return new WaitForSeconds(slideTime);
		}
		speed = speedTemp;
		slideDuration = durationTemp;
	}
	IEnumerator Muddy()
	{
		InMud = true;
		speed = 5f;
		jumpSpeed = 10f;
		yield return null;
	}
	IEnumerator LeaveMud()
	{
		InMud = false;
		speed = 30f;
		jumpSpeed = 45;
		yield return null;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			myAnimate.SetTrigger ("Jump");
		}
		
		
		if (Input.GetKeyDown (KeyCode.Space) && StaticVar.JumperCount < jumpCountMax) {
			StaticVar.JumperCount++;

			//myAnimate.SetLayerWeight (1, 1);
			tempPos.y = jumpSpeed;
			StaticVar.Grounded = false;

			}
		//if(Input.GetKeyUp(KeyCode.Space))
			//{
			//	myAnimate.SetTrigger("Jump");
			//}
		if (myCC.isGrounded) {
			StaticVar.JumperCount = 0;
			//myAnimate.SetLayerWeight (1, 0);
			myAnimate.ResetTrigger ("Jump");
			myAnimate.SetBool ("Landing", false);
		}

			if (myCC.velocity.y < 0) {
				myAnimate.SetBool ("Landing", true);
			}
			
			if (Input.GetKey (KeyCode.RightArrow) && Input.GetKeyDown (KeyCode.S)) {
				StartCoroutine (Slide ());
			}

			if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKeyDown (KeyCode.S)) {
				StartCoroutine (Slide ());
			}

			tempPos.y -= gravity;
			tempPos.x = speed * Input.GetAxis ("Horizontal");
		tempPos.z = 1;
			myCC.Move (tempPos * Time.deltaTime);
		myAnimate.SetFloat ("speed", Mathf.Abs (tempPos.x));

		}

	public void EntermudHandler(mud obj)
	{
		if (InMud == false) {
			StartCoroutine (Muddy ());
		} else if (InMud == true) {
			StartCoroutine (LeaveMud ());
		}
	}
}