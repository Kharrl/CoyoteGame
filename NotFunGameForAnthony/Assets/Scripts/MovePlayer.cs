using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	private CharacterController myCC;
	private Vector3 tempPos;
	public float RotSpeed=60;
	public float speed = 5.0f;
	private float gravity = 4f;
	public float jumpSpeed = 45.0f;
	public int jumpCountMax = 1;

	void Start ()
	{

		myCC = GetComponent<CharacterController> ();

	}
		
	void Update ()
	{
		tempPos.y -= gravity;
		transform.Rotate(0, Input.GetAxis("Horizontal") * RotSpeed * Time.deltaTime, 0);
		transform.Translate(Vector3.forward * Input.GetAxis ("Vertical")*speed*Time.deltaTime);
		myCC.Move (tempPos * Time.deltaTime);
	}
		
	}











