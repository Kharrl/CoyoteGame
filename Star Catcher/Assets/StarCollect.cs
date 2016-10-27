using UnityEngine;
using System.Collections;
using System;

public class StarCollect : MonoBehaviour {
	public static Action<StarCollect> IsCollected;
	// Use this for initialization
	void OnTriggerEnter()
	{
		IsCollected (this.gameObject);
	}
}
