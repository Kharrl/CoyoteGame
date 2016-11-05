using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour {
	public Text Timer;
	public Text Health;
	public Text Scoreboard;
	public Text AmmoCounter;
	// Use this for initialization
	void Start(){
		ZombieBehavior.reDead += redeadHandler;
		Scoreboard.text = "Score: " + StaticVars.playerScore;
		Health.text = "Lives: " + StaticVars.playerHealth;
		AmmoCounter.text = "Ammo: " + StaticVars.Ammo;
	}

	void redeadHandler(ZombieBehavior obj)
	{
		Scoreboard.text = "Score: " + StaticVars.playerScore;
	}
	void BangHandler(fireweapon obj)
	{
		AmmoCounter.text = "Ammo: " + StaticVars.Ammo;
}
}
