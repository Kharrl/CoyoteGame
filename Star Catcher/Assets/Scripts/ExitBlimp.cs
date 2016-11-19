﻿using UnityEngine;
using System.Collections;
using System;

public class ExitBlimp : MonoBehaviour {
	static public Action<Transform> Landed;
	static public Action<GameObject> Landing;
	public Camera BlimpCam;
	public Camera MainCam;
	public bool canSpawnBunny = true;
	public GameObject newCamera;
	public GameObject SpawnPlayer;
	public Transform Spawn;
	private GameObject Player;

	void Start()
	{
		newCamera.SetActive (false);
		BlimpCam.enabled = false;
		MainCam.enabled = false;
	}
	IEnumerator BlimpLanding()
	{
		newCamera.SetActive (true);
		BlimpCam.enabled = false;
		MainCam.enabled = true;
		Landing (Player);
		yield return null;
	}
	// Use this for initialization
	public void OnTriggerEnter()
	{
		if (canSpawnBunny == true) {
			StartCoroutine (BlimpLanding ());
			Player=Instantiate (SpawnPlayer, Spawn.position, Spawn.rotation)as GameObject;
			Landed (Player.transform);
			canSpawnBunny = false;
		}

	}

}
