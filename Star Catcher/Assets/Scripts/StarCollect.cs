using UnityEngine;
using System.Collections;
using System;

public class StarCollect : MonoBehaviour {
	public GameObject Star;
	public static Action<StarCollect> IsCollected;
	// Use this for initialization
	void OnTriggerEnter()
	{
		if (StaticVar.StarPower < StaticVar.MaxStarPower) {
			StaticVar.StarPower += 10;
			print (StaticVar.StarPower);
		}
		StaticVar.StarsCollected++;
		print (StaticVar.StarsCollected);
		IsCollected (this);
		Destroy (Star);
	}
}
