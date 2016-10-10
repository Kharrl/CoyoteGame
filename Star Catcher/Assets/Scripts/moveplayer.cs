using UnityEngine;
using System.Collections;

public class moveplayer: MonoBehaviour
{
	private CharacterController myCC;
	private Vector3 tempPos;
	public float speed = 10.0f;
	public float gravity = 9.81f;
	public float jumpSpeed = 1.0f;
	public int jumpCount = 0;
	public int jumpCountMax = 1;
	public int slideDuration = 100;
	public float slideTime = 0.1f;


	void Start ()
	{
		myCC = GetComponent<CharacterController> ();

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


	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
		{
			jumpCount++;
			tempPos.y = jumpSpeed;
		}
		if(myCC.isGrounded)
		{
			jumpCount = 0;
		}

		if(Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
		{
			StartCoroutine(Slide());
		}

		if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
		{
			StartCoroutine(Slide());
		}

		tempPos.y -= gravity;
		tempPos.x = speed*Input.GetAxis("Horizontal");
		myCC.Move(tempPos * Time.deltaTime);
	}
}