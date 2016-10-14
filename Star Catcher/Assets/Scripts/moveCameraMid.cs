using UnityEngine;
using System.Collections;
using System;

public class moveCameraMid : MonoBehaviour {
	public static Action<moveCameraMid> Drop;
	void OnTriggerEnter(){
		if (Drop != null) {
			Drop (this);
		}
	}
}
