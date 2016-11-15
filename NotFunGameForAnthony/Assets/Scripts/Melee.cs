using UnityEngine;
using System.Collections;
using System;

public class Melee : MonoBehaviour {
	public static Action<Melee>Hit;
	// Use this for initialization
	void Start () {
		userupdate.fakeUpdate += FakeUpdateHandler;

	}
	
	// Update is called once per frame
	void FakeUpdateHandler (userupdate obj) {
		if (Input.GetKeyDown (KeyCode.LeftCommand))
			Hit (this);
	}
}
