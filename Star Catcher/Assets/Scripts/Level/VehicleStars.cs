using UnityEngine;
using System.Collections;

public class VehicleStars : MonoBehaviour {

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
		Destroy (this.gameObject);
		yield return null;
	}
}
