using UnityEngine;
using System.Collections;

public class HealthPowerUp : MonoBehaviour, IPowerup {
	public int Health=50;
	public Transform store;

	public void OnTriggerEnter ()
	{
		StaticVars.playerHealth+=Health;
		transform.position = store.position;
	}
	public Rigidbody PowerUp {
		set {
			PowerUp=GetComponent<Rigidbody>();
		}
	}



}
