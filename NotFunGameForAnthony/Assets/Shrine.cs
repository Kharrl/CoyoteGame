using UnityEngine;
using System.Collections;
using System;

public class Shrine : MonoBehaviour {
	public static Action Healing;
	public static Action deadshrine;
	public int Health = 500;
	public GameObject myShrine;
	// Use this for initialization
	void Start () {
		WeaponBase.FireWep += DmgHandler;
	}
	
	// Update is called once per frame
	void DmgHandler (int D) {
		Health -= D;
		if (Health <= 0) {
			myShrine.SetActive (false);
			deadshrine ();
		}

	}
	void OnTriggerEnter ()
	{
		int i = 5;
		while (i > 0) {
			Healing ();
			i--;
		}
	}
}
