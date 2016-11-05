using UnityEngine;
using System.Collections;

public class ZombieBehavior : MonoBehaviour {
	public bool CanBeShot=false;
	private int ZombieHealth = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	void banghandler()
	{
		if (CanBeShot = true) {
			StaticVars.playerScore += 10;
			ZombieHealth--;
		}
		if (ZombieHealth == 0)
			Destroy (this.gameObject);
	}
}
