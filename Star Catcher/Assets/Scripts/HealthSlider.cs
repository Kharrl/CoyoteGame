using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour {
	public Slider myStarPower;
	private float myPower;

	void Start()
	{
		myPower = StaticVar.StarPower;
		myStarPower.value = myPower;
		StarCollect.IsCollected += StarCollectedHandler;
		HurtBunny.BunnyHit += BunnyHitHandler;
		VehicleStars.BlimpCollect += CollectHandler;
	}

	public void StarCollectedHandler (StarCollect obj)
	{
		myPower = StaticVar.StarPower;
		myStarPower.value = myPower;
	}
	public void BunnyHitHandler(HurtBunny obj)
	{
		myPower = StaticVar.StarPower;
		myStarPower.value = myPower;
	}
	void CollectHandler(){
		myPower = StaticVar.StarPower;
		myStarPower.value = myPower;
	}

}
