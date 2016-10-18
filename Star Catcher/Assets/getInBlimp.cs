using UnityEngine;
using System.Collections;
using System;

public class getInBlimp : MonoBehaviour {
	public static Action<getInBlimp> GetIn;
	// Use this for initialization
	void OnTriggerEnter()
	{
		GetIn (this);
	}
}
