using UnityEngine;
using System.Collections;
using System;
public class MountFrostyFalls : MonoBehaviour {
	public static Action <MountFrostyFalls> Falling;
	// Use this for initialization
	void OnTriggerStay()
	{
		Falling (this);
	}
}
