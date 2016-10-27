using UnityEngine;
using System.Collections;
using System;

public class time : MonoBehaviour {
	public static Action<time> TimeUP;
	public float myTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTime -= Time.deltaTime;
		if (myTime <= 0f)
			TimeUP(this); 
	
	}

}
