using UnityEngine;
using System.Collections;
using System;


public class ForceStarForward : MonoBehaviour {
	public static Action<ForceStarForward> AddForceForward;
	void OnTriggerEnter()
	{
		AddForceForward (this);
	}
}
