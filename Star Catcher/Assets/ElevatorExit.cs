using UnityEngine;
using System.Collections;
using System;
public class ElevatorExit : MonoBehaviour {
	public static Action<ElevatorExit> BottomButton;
	// Use this for initialization
	void OnTriggerEnter()
	{
		BottomButton (this);
	}
}
