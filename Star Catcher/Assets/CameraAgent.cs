using UnityEngine;
using System.Collections;

public class CameraAgent : MonoBehaviour{
	public float Gravity = 2f;
	public float Speed = 5;
	private Vector3 tempPos;
	private CharacterController myCC;

	// Use this for initialization
	void Start () {
		myCC = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		tempPos.x = Speed * Time.deltaTime;
		tempPos.y = -Gravity*Time.deltaTime;
		myCC.Move (tempPos);
	}

}
