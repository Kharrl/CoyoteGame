using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour {
	public Text Timer;
	public Text Health;
	public Text Scoreboard;
	public Text AmmoCounter;
	public bool GameActive = true;
	// Use this for initialization
	void Start(){
		ZombieBehavior.Redead += redeadHandler;
		Scoreboard.text = "Score: " + StaticVars.playerScore;
		Health.text = "Lives: " + StaticVars.playerHealth;
		AmmoCounter.text = "Ammo: " + StaticVars.Ammo;
		StartCoroutine (GameTiming ());

	}
	IEnumerator GameTiming()
	{
		while (GameActive) {
			Timer.text = "Time: " + Mathf.Round(StaticVars.GameTime -= Time.deltaTime);
			yield return new WaitForSeconds (0.1f);
		}
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
