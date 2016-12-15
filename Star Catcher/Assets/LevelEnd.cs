using UnityEngine;
using System.Collections;
using System;

public class LevelEnd : MonoBehaviour {
	public static Action levelending;
	// Use this for initialization
	void OnTriggerEnter () {
		levelending ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
