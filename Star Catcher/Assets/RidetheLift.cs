using UnityEngine;
using System.Collections;

public class RidetheLift : MonoBehaviour {
	public GameObject Elevator;
	public GameObject CameraAgt;
	public GameObject player;
	// Use this for initialization
	void OnTriggerEnter()
		{
		
		Elevator.transform.parent = CameraAgt.transform;
		player.transform.parent = Elevator.transform;
		}
}
