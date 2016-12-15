using UnityEngine;
using System.Collections;
using System;

public class columndmg : MonoBehaviour {
	public int Power=10;
	public static Action<int> killem;
	public int Countdown = 15;
	// Use this for initialization
	void Start()
	{
		for(int Countdown=0; Countdown==Countdown; Countdown++)
			Power=BuildPower(Power);
	
	}
	
	// Update is called once per frame
	int BuildPower (int built) {
		int growing;
		growing = built++;
		return growing;
	}
}
