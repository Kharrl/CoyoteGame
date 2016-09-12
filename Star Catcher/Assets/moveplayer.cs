using UnityEngine;
using System.Collections;

public class moveplayer : MonoBehaviour {
	//use to move the player
	public float speed = 13f;
	private CharacterController controller;
	//use to assign location as a temp variable 
	private Vector3 tempPosition;
	private float gravity = 9.81f;
	private float jumpspeed = 200f;
	public int jumpcount =0;


	// Use this for initialization
	void Start () {
		//this finds the character controller component
		controller = GetComponent<CharacterController>();


	}
	
	// Update is called once per frame
	void Update () {
		if (controller.isGrounded) {
			jumpcount = 0;
		}
		
		//using axis as an input with speed the character can hold or move left or right
		if (Input.GetKeyDown (KeyCode.Space)&&jumpcount<2)
		{
			jumpcount++;
			tempPosition.y += jumpspeed;
		}
	
		tempPosition.x = speed*Input.GetAxis("Horizontal");
		tempPosition.y -= gravity;
		tempPosition *= Time.deltaTime;
		controller.Move (tempPosition);



		}
	

	}
