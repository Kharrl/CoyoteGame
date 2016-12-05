
using UnityEngine;
using System.Collections;
using System;



public class userupdate : MonoBehaviour {
	public static Action<KeyCode> UserInputs;
	public static Action<userupdate> fakeUpdate;

	void Update () {
		
		if(Input.GetKeyDown(KeyCode.X))
			UserInputs(KeyCode.X);
		if (Input.GetKeyDown (KeyCode.Z))
			UserInputs (KeyCode.Z);

		fakeUpdate (this);
	}
			}




