using UnityEngine;
using System.Collections;
using System;

public class ResetBomb : MonoBehaviour {
	public static Action DestroyBomb;
	// Use this for initialization
	void OnTriggerEnter()
	{
		DestroyBomb();
	}
}
