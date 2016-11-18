﻿using UnityEngine;
using System.Collections;
using System;

public class ExitBlimp : MonoBehaviour {
	static public Action<ExitBlimp> Landed;
	public Camera BlimpCam;
	public Camera MainCam;
	public bool canSpawnBunny = true;

	void Start()
	{
		
	}
	IEnumerator BlimpLanding()
	{
		
		Landed (this);
		BlimpCam.enabled = false;
		MainCam.enabled = true;
		yield return null;
	}
	// Use this for initialization
	public void OnTriggerEnter()
	{
		if (canSpawnBunny == true) {
			StartCoroutine (BlimpLanding ());
			canSpawnBunny = false;
		}

	}

}
