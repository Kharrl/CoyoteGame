using UnityEngine;
using System.Collections;

public class ZombieMeleeRange : ZombieBehavior {
	public bool CanBePunched=false;
	void Start()
	{
		Melee.Hit += HitHandler;
	}
	void HitHandler(Melee obj)
	{
		TakeDamage ();
		if (ZombieHealth == 0)
			KillZombie ();
	}
	// Use this for initialization
	void OnTriggerEnter(){
		CanBePunched = true;
		print ("Zombie can Be punched");
	}
}
