using UnityEngine;
using System.Collections;
using System;

public class GreenlandCamera : MonoBehaviour {
	public static Action<GreenlandCamera> Hill;

	public void OnTriggerStay()
	{
		Hill(this);
	}
}
