using UnityEngine;
using System.Collections;
using System;

public class Updater : MonoBehaviour {
	public static Action <KeyCode> Controls;
	public static Action <float> Movement;
	public static Action <float> Turning;
	public float PlayerMove;
	public float PlayerTurn;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		PlayerMove = Input.GetAxis ("Vertical");
		Movement(PlayerMove);
		PlayerTurn = Input.GetAxis ("Horizontal");
		Turning(PlayerTurn);
		if (Input.GetKeyDown(KeyCode.Space))
			Controls (KeyCode.Space);
		if(Input.GetKeyDown(KeyCode.Alpha1))
			Controls(KeyCode.Alpha1);
		if (Input.GetKeyDown (KeyCode.Alpha2))
			Controls (KeyCode.Alpha2);
		if (Input.GetKeyDown(KeyCode.Alpha3))
			Controls (KeyCode.Alpha3);
		if (Input.GetKeyDown (KeyCode.Alpha4))
			Controls (KeyCode.Alpha4);
	}
}
