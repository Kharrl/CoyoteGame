using UnityEngine;
using System.Collections;

public class HealerEnemy : EnemyBase{

	void Awake()
	{
		Enemy.destination = Shrine.position;
		EnemySpeed = 10;

}
void OnTriggerEnter(){
	InRange = true;
}
	void ShrineDestroyHandler()
	{
		Enemy.destination = Player.position;
	}
	// Use this for initialization
	
}
