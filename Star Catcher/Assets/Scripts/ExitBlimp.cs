using UnityEngine;
using System.Collections;
using System;

public class ExitBlimp : MonoBehaviour {
	static public Action<Transform> Landed;
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
		Landed (Player.transform);
		BlimpCam.enabled = false;
		MainCam.enabled = true;
		yield return null;
	}
	// Use this for initialization
	public void OnTriggerEnter()
	{
		if (canSpawnBunny == true) {
			StartCoroutine (BlimpLanding ());
			Player=Instantiate (SpawnPlayer, Spawn.position, Spawn.rotation)as GameObject;

			canSpawnBunny = false;
		}

	}

}
