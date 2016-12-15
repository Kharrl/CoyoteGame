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
		

			Timing = StaticVars.GameTime += Time.deltaTime;
			Scoreboard.text = "Score: " + StaticVars.playerScore;
			Health.text = "Lives: " + StaticVars.playerHealth;
			AmmoCounter.text = "Ammo: " + StaticVars.Ammo;
			Timer.text = "You have survived for: " + Mathf.Round (Timing);
		}
	}


