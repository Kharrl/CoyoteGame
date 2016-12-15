using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class WaveLaunch : MonoBehaviour {
	public List<GameObject> Enemies;
	private int i;

	// Use this for initialization
	void Start () {
		EnemyBase.AddMe += EnemyListHandler;
		SpawnList.SpawnLocation += SpawnHandler;

	}
	
	// Update is called once per frame
	void EnemyListHandler (GameObject obj) {
		Enemies.Add (obj);
	}
	void SpawnHandler(Transform _t)
	{
		
		i = UnityEngine.Random.Range (0, Enemies.Count);
		Enemies [i].transform.position = _t.position;
		Enemies.Remove(Enemies[i]);
	}
}
