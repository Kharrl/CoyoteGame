using UnityEngine;
using System.Collections;
using System;

public class MoveCameraUp : MonoBehaviour {
	public static Action<MoveCameraUp> Lift;
	void OnTriggerEnter(){
		Lift (this);
	}
}

