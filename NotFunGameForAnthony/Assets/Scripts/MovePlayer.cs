using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	private CharacterController myCC;
	private Vector3 tempPos;
	private Quaternion tempRotate;
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

		myCC = GetComponent<CharacterController> ();

	}
		
	void Update ()
	{
		tempPos.y -= gravity;
		tempPos.x = speed * Input.GetAxis ("Horizontal");
		tempRotate.y = speed * Input.GetAxis ("Vertical");
		myCC.Move (tempPos * Time.deltaTime);
	}
		
	}











