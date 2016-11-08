using UnityEngine;
using System.Collections;
using System;

public class KillBunny : MonoBehaviour {
	public static Action<KillBunny> Kill;
	// Use this for initialization
	public void OnTriggerEnter()
	{
		Kill (this);
	}
}
