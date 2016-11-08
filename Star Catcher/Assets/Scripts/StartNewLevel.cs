using UnityEngine;
using System.Collections;
using System;

public class StartNewLevel : MonoBehaviour {
	public static Action<StartNewLevel> NewLevel;

	void OnMouseDown()
	{
		NewLevel (this);
	}

}
