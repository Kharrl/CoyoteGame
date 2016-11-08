using UnityEngine;
using System.Collections;
using System;

public class mud : MonoBehaviour {
	public static Action<mud> Entermud;
	// Use this for initialization
	void OnTriggerEnter()
	{
		Entermud (this);
	}
	void OnTriggerExit()
	{
		Entermud (this);
	}
}
