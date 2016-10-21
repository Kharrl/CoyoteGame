using UnityEngine;
using System.Collections;
using System;
public class ExitBoat : MonoBehaviour {
	static public Action<ExitBoat> Docked;
	public bool canSpawnBunny = true;

	void Start()
	{
		
	}
	// Use this for initialization
	public void OnTriggerEnter()
	{
		if (canSpawnBunny == true) {
			Docked (this);
			canSpawnBunny = false;
		}

	}

}
