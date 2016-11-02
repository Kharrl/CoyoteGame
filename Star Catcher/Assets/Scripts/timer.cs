using UnityEngine;
using System.Collections;
using System;

public class timer : MonoBehaviour {
	public static Action<timer> TimeUP;
	public static float myTime= 300f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		myTime -=Time.deltaTime;
		print (myTime);

	
	}

}
