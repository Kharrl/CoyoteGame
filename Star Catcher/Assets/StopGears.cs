using UnityEngine;
using System.Collections;
using System;

public class StopGears : MonoBehaviour {
	public static Action<StopGears> GearStop;
	// Use this for initialization
	void OnTriggerEnter () {
		GearStop (this);
	}
	

}
