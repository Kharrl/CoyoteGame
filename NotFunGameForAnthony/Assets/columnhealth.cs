using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class columnhealth : MonoBehaviour {
	public int Health=0;
	public List <GameObject> BadGuys;

	// Use this for initialization
	void Start () {
		EnemyBase.AddMe += HealthHandler;
		StartCoroutine (BuildHealth ());
	}
	IEnumerator BuildHealth()
	{
		yield return new WaitForSeconds (1);
		foreach(GameObject EnemyBase in BadGuys)
		{
			Health += 10;
		}
	
	}
	// Update is called once per frame
	void HealthHandler (GameObject obj) {
		BadGuys.Add (obj);
	}
}
