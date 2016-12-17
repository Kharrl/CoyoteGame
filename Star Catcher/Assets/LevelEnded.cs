using UnityEngine;
using System.Collections;
using System;

public class LevelEnded : MonoBehaviour {
	public static Action GameOver;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter()
	{
		GameOver ();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
