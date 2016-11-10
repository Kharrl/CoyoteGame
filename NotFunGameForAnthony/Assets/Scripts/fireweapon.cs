using UnityEngine;
using System.Collections;
using System;

public class fireweapon : MonoBehaviour {
	public static Action<fireweapon> bang;
	void Start()
	{
		userupdate.UserInputs += UserInputHandler;
	}
	// Use this for initialization
	void UserInputHandler(userupdate t)
	{
		if (StaticVars.Ammo > 0)
			bang (this);
		StaticVars.Ammo--;
	}
}
