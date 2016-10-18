using UnityEngine;
using System.Collections;
using System;

public class MoveCameraUp : MonoBehaviour {
	public static Action<MoveCameraUp> Lift;
	public bool canBeTriggered =true;
	void OnTriggerEnter(){
		if(canBeTriggered==true)
		{
			canBeTriggered = false;
			StartCoroutine (SendLift());


	}
	}
		IEnumerator SendLift()
		{

			Lift(this);
			yield return new WaitForSeconds(10);
		canBeTriggered = true;
			
		}
}

