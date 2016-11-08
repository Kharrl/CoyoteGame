using UnityEngine;
using System.Collections;
using System;

public class GreenlandDowns : MonoBehaviour {
	static public Action<GreenlandDowns> Decent;

	public void OnTriggerStay()
	{
		Decent (this);
	}

}
