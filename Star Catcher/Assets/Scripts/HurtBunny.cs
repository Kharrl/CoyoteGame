using UnityEngine;
using System.Collections;
using System;
public class HurtBunny : MonoBehaviour {
	public static Action<HurtBunny> BunnyHit;
	public int DamageGiven = 25;
	// Use this for initialization
	void OnTriggerEnter()
	{
		StartCoroutine (Damaged ());
	}
	IEnumerator Damaged()
	{
		StaticVar.StarPower = StaticVar.StarPower - DamageGiven;
		BunnyHit (this);
		yield return new WaitForSeconds (3);
	}

}

