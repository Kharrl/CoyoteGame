using UnityEngine;
using System.Collections;
using System;

public class ExitBlimp : MonoBehaviour {
	static public Action<ExitBlimp> Landed;
	public Transform Spawn;
	public GameObject player;
	public bool canSpawnBunny = true;

	void Start()
	{
		Spawn = GetComponent<Transform> ();
	}
	IEnumerator BlimpLanding()
	{
		Instantiate (player, Spawn.position, Spawn.rotation);
		Landed (this);
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
