using UnityEngine;
using System.Collections;
using System;

public class ExitBlimp : MonoBehaviour {
	static public Action<ExitBlimp> Landed;
	public Camera BlimpCam;
	public Camera MainCam;
	public bool canSpawnBunny = true;
	public GameObject newCamera;

	void Start()
	{
		newCamera.SetActive (false);
		BlimpCam.enabled = false;
		MainCam.enabled = false;
	}
	IEnumerator BlimpLanding()
	{
		newCamera.SetActive (true);
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
