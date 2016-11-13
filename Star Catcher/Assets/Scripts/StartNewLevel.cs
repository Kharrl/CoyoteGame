using UnityEngine;
using System.Collections;
using System;

public class StartNewLevel : MonoBehaviour {
	public static Action<StartNewLevel> NewLevel;
	void Start()
	{
		StaticVar.StarPower = 50;
	}

	void OnMouseDown()
	{
		
		NewLevel (this);
	}

}
