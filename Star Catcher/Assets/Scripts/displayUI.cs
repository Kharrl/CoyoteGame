using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class displayUI : MonoBehaviour {
	public static Action GameEnd;
	public Text CollectedStars;
	public Text GameTimer;
	public Text GameOver;
	public Text routines;
	public Text Retry;
	public Text Quit;
	// Use this for initialization
	void Start () {
		HurtBunny.BunnyHit += BunnyGameHandler;
		GameOver.enabled = false;
		Quit.enabled = false;
		Retry.enabled = false;
		routines.enabled = false;
	}
	void OnDestroy(){
		HurtBunny.BunnyHit -= BunnyGameHandler;
	}
	
	// Update is called once per frame
	void Update () {
		CollectedStars.text = "Stars Collected:"+StaticVar.StarsCollected;
		GameTimer.text = "Time:"+Mathf.Round (StaticVar.GameClock-=Time.deltaTime);
		if (StaticVar.GameClock <= 0f) {
			StaticVar.GameClock = 0f;
			GameOver.enabled=true;
			Quit.enabled = true;
			Retry.enabled = true;
			routines.enabled = true;
			GameEnd ();
		}
	}
	void BunnyGameHandler(HurtBunny obj)
	{
		if (StaticVar.StarPower <= 0) {
			
			GameOver.enabled = true;
			Quit.enabled = true;
			Retry.enabled = true;
			routines.enabled = true;
			GameEnd ();
		}
}
}