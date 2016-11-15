using UnityEngine;
using System.Collections;
using System;

public class ZombieBehavior : ZombieAgentScript {
	public int ZombieHealth = 10;
	private int GunDamage = 1;
	public static Action<ZombieBehavior> Redead;
	public bool CanBeShot = false;

	// Use this for initialization
	void Start () {
		userupdate.fakeUpdate += FakeUpdateHandler;
		fireweapon.bang += banghandler;
	}
	void FakeUpdateHandler(userupdate obj){
		
		Redead (this);
	}
	void OnTriggerStay()
	{
		CanBeShot = true;
		print ("can be shot");
	}
	void OnTriggerExit()
	{
		CanBeShot = false;
		print ("Out of Range");
	}

	void banghandler(fireweapon obj)
	{
		if (CanBeShot == true) {
			TakeDamage ();
		}
	}
	public void TakeDamage()
	{
		int NewHealth;
		StaticVars.playerScore += 10;
		print (StaticVars.playerScore);
		NewHealth = ZombieHealth - GunDamage;
		ZombieHealth = NewHealth;
		print ("Zombie Health: " + ZombieHealth);
		if (ZombieHealth == 0) {
			print ("Zombie should have died");
			KillZombie ();
		}
	}
		
	void OnDestroy()
	{
		userupdate.fakeUpdate -= FakeUpdateHandler;
		fireweapon.bang -= banghandler;
	}
}
