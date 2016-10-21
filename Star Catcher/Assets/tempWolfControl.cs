using UnityEngine;
using System.Collections;

public class tempWolfControl : MonoBehaviour {
	private CharacterController Wolfcontrol;
	private float wolfspeed=-20f;
	private Vector3 wolfpos;
	// Use this for initialization
	void Start () {
		Wolfcontrol = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		wolfpos.x = wolfspeed * Time.deltaTime;
		Wolfcontrol.Move (wolfpos);
	}
}
