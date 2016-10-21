using UnityEngine;
using System.Collections;
using System;

public class EnterBoat : MonoBehaviour {
	public static Action<EnterBoat>HopIn;
	// Use this for initialization
	void OnTriggerEnter()
	{
		HopIn (this);
	}
	
	}

