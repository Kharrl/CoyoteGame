﻿using UnityEngine;
using System.Collections;
using System;

public class ZombieBehavior : MonoBehaviour {
	public bool CanBeShot=false;
	private int ZombieHealth = 1;
	public static Action<ZombieBehavior> reDead;

	// Use this for initialization
	void Start () {
		fireweapon.bang += banghandler;
	}
	void OnTriggerStay()
	{
		CanBeShot = true;
	}

	void banghandler(fireweapon obj)
	{
		if (CanBeShot == true) {
			StaticVars.playerScore += 10;
			ZombieHealth--;
		}
		if (ZombieHealth == 0)
			reDead (this);
			Destroy (this.gameObject);
	}
}