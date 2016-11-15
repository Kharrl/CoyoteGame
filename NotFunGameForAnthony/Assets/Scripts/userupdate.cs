
using UnityEngine;
using System.Collections;
using System;



public class userupdate : MonoBehaviour {
	public static Action<KeyCode> UserInputs;
	public static Action<userupdate> fakeUpdate;
	public static Action<userupdate> FireGun;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.RightCommand)) {
			print ("Gun Fired");
			FireGun (this);
		}
		fakeUpdate (this);
	}

}


