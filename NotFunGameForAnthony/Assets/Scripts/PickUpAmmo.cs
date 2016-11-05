using UnityEngine;
using System.Collections;

public class PickUpAmmo : MonoBehaviour {

	void OnCollisionEnter()
	{
		StaticVars.Ammo += 10;
		Destroy (this.gameObject);
	}
}
