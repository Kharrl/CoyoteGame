using UnityEngine;
using System.Collections;
using System;
public class UpdateandDel : MonoBehaviour {
	public int playerHealth = 250;
	//Actions are a type of delegate. Delegates contain functions just as vars contain data 
	Action DisplayHealth;
	Action killPlayer;
	Action EndofGame;
	void DesplayHealth()
	{
		print ("Health is fun");
		DisplayHealth = null;
		killPlayer = killPlayerHandler;
	}
	void EndtheGameHandler()
	{
		print ("you Lose");
		EndofGame = null;
	}
	void killPlayerHandler ()
	{
		playerHealth--;
		print (playerHealth);
		if (playerHealth < 0) {
			killPlayer = null;
			EndofGame = EndtheGameHandler;
		}
	}
	// Use this for initialization
	void Start () {
		DisplayHealth = DesplayHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if(DisplayHealth != null)
		DisplayHealth ();
		if (killPlayer != null)
			killPlayer ();
		if (EndofGame != null)
			EndofGame ();
	}
}
