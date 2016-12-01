using UnityEngine;
using System.Collections;
using System;
public class ChaseBunny : MonoBehaviour {
	public static Action <int> RunSpeeds;
	public int ChaseDirection;
	public float Delay;
	// Use this for initialization
	IEnumerator FollowBunny()
	{
		yield return new WaitForSeconds (Delay);
		RunSpeeds (ChaseDirection);
	}
	// Update is called once per frame
	void OnTriggerEnter () {
		StartCoroutine (FollowBunny ());
	}
}
