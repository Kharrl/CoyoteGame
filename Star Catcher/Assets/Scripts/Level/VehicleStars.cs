using UnityEngine;
using System.Collections;
using System;

public class VehicleStars : MonoBehaviour {
	public static Action BlimpCollect;
	void OnTriggerEnter()
	{
		StartCoroutine (StarCollecter ());
	}
	IEnumerator StarCollecter()
	{

		if (StaticVar.StarPower < StaticVar.MaxStarPower) {
			StaticVar.StarPower += 10;
			print (StaticVar.StarPower);
		}
		StaticVar.StarsCollected++;
		print (StaticVar.StarsCollected);
		BlimpCollect();
		Destroy (this.gameObject);
		yield return null;
	}

}
