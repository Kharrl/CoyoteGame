using UnityEngine;
using System.Collections;
using System;

public class RidetheLift : MonoBehaviour {
	public static Action<RidetheLift> Triggered;
	public GameObject Elevator;
	public GameObject CameraAgt;
	public GameObject player;
	// Use this for initialization
	void OnTriggerEnter()
		{
		Triggered (this);
		Elevator.transform.parent = CameraAgt.transform;
		player.transform.parent = CameraAgt.transform;
		}
}
