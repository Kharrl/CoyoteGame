using UnityEngine;
using System.Collections;
using System;


public class MountFrostyCam : MonoBehaviour {
	public static Action<MountFrostyCam> Climbing;
	public void OnTriggerStay()
	{
		Climbing(this);
	}

}
