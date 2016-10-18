using UnityEngine;
using System.Collections;

public class moveplayer: MonoBehaviour
{
	private CharacterController myCC;
	private Vector3 tempPos;
	public float speed = 30.0f;
	private float gravity = 3f;
	public float jumpSpeed = 45.0f;
	public int jumpCount = 0;
	public int jumpCountMax = 1;
	public int slideDuration = 100;
	public float slideTime = 0.1f;
	public bool InMud=false;


	void Start ()
	{
		myCC = GetComponent<CharacterController> ();
		mud.Entermud += EntermudHandler;

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
		
			if (Input.GetKeyDown (KeyCode.Space) && jumpCount < jumpCountMax) {
				jumpCount++;
				tempPos.y = jumpSpeed;
			}
			if (myCC.isGrounded) {
				jumpCount = 0;
			}

			if (Input.GetKey (KeyCode.RightArrow) && Input.GetKeyDown (KeyCode.S)) {
				StartCoroutine (Slide ());
			}

			if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKeyDown (KeyCode.S)) {
				StartCoroutine (Slide ());
			}

			tempPos.y -= gravity;
			tempPos.x = speed * Input.GetAxis ("Horizontal");
			myCC.Move (tempPos * Time.deltaTime);
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