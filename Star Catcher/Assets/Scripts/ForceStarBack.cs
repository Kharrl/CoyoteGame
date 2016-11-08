using UnityEngine;
using System.Collections;
using System;
public class ForceStarBack : MonoBehaviour {

	public static Action<ForceStarBack> AddBackForce;

	void OnTriggerEnter()
	{
		AddBackForce (this);
	}
}
