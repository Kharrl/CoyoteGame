using UnityEngine;
using System.Collections;

public class PickUpAmmo : MonoBehaviour {

	void OnTriggerEnter()
	{
		StaticVars.Ammo += 10;
		Destroy (this.gameObject);
	}
}
