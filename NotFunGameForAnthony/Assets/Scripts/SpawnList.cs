using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class SpawnList : MonoBehaviour {
	public List <Spawner> MyList;
	public static Action<Transform> SpawnLocation;
	private int i;
	// Use this for initialization
	void Start () {
		Spawner.AddSpawns += SpawnListHandler;
		RunWave ();

	}
	void RunWave()
	{
		StartCoroutine (SendSpawn ());
	}
	// Update is called once per frame
	void SpawnListHandler (Spawner obj) {
		MyList.Add (obj);
	}
	IEnumerator SendSpawn()
	{
		yield return new WaitForSeconds (5f);
		i = UnityEngine.Random.Range (0, MyList.Count - 1);
		SpawnLocation (MyList [i].transform);
		RunWave ();
	}
}
