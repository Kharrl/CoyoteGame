
using UnityEngine;
using System.Collections;
using System;



public class userupdate : MonoBehaviour {
	public static Action<KeyCode> UserInputs;
	public static Action<userupdate> fakeUpdate;
	// Use this for initialization
	void Start () {
	}
		
	// Update is called once per frame
	void Update () {
		fakeUpdate (this);
	}

}


