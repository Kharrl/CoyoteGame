using UnityEngine;
using System.Collections;

public class StandardEnemy : EnemyBase {

	// Use this for initialization
	void Awake()
	{
		EnemySpeed = 3f;
		Enemy.destination = Player.position;
		StartCoroutine (Stalk ());
	}
	void OnTriggerEnter(){
		InRange = true;
	}
	IEnumerator Stalk(){
		yield return new WaitForSeconds (0.5f);
		Awake ();
}
}
