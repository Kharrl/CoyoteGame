using UnityEngine;
using System.Collections;
using System;

public class fireweapon : MonoBehaviour {
	public static Action<fireweapon> bang;
	// Use this for initialization
	void OnMouseDown()
	{
		if (StaticVars.Ammo > 0)
			bang (this);
		StaticVars.Ammo--;
	}
}
