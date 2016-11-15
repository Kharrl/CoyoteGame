using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour {
	public Text Timer;
	public Text Health;
	public Text Scoreboard;
	public Text AmmoCounter;
	private float Timing;
	// Use this for initialization
	void Start(){
		userupdate.fakeUpdate += FakeUpdateHandler;
	}
	void FakeUpdateHandler(userupdate obj){
		Timing=StaticVars.GameTime += Time.deltaTime;
		ZombieBehavior.Redead += redeadHandler;
		Scoreboard.text = "Score: " + StaticVars.playerScore;
		Health.text = "Lives: " + StaticVars.playerHealth;
		AmmoCounter.text = "Ammo: " + StaticVars.Ammo;
		Timer.text = "You have survived for: " + Mathf.Round(Timing);

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
