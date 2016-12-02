using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class HealthSlider : MonoBehaviour {
	public Slider myStarPower;
	private float myPower;
	public static Action checkHealth;
	void Start()
	{
		myPower = StaticVar.StarPower;
		myStarPower.value = myPower;
		StarCollect.IsCollected += StarCollectedHandler;
		HurtBunny.BunnyHit += BunnyHitHandler;
		VehicleStars.BlimpCollect += CollectHandler;
	}
	void OnDamage(){
		HurtBunny.BunnyHit -= BunnyHitHandler;
		VehicleStars.BlimpCollect -= CollectHandler;
	}

	public void StarCollectedHandler (StarCollect obj)
	{
		myPower = StaticVar.StarPower;
		myStarPower.value = myPower;
		checkHealth();
	}
	public void BunnyHitHandler(HurtBunny obj)
	{
		myPower = StaticVar.StarPower;
		myStarPower.value = myPower;
		checkHealth();
	}
	void CollectHandler(){
		myPower = StaticVar.StarPower;
		myStarPower.value = myPower;
		checkHealth();
	}

}
