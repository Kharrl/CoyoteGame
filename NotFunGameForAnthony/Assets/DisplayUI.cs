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
	}

	void redeadHandler(ZombieBehavior obj)
	{
		Scoreboard.text = "Score: " + StaticVars.playerScore;
	}
}
