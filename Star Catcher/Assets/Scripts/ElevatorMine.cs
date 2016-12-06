using UnityEngine;
using System.Collections;
using System;

public class ElevatorMine : MonoBehaviour {
	public GameObject Mineobj;
	public Rigidbody rbMine;
	public GameObject Elevator;
	IEnumerator StickToElevator(){
		yield return new WaitForSeconds (0.01f);
		rbMine.isKinematic = false;
		Mineobj.transform.parent = Elevator.transform;
	}
	void OnTriggerEnter()
	{
		print ("Triggered");
		StartCoroutine (StickToElevator ());
	}
}
