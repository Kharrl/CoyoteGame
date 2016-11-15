using UnityEngine;
using System.Collections;
using System;

public class fireweapon : MonoBehaviour {
	public static Action<fireweapon> bang;
	void Start()
	{
		userupdate.FireGun += UserInputHandler;
	}
	// Use this for initialization
	void UserInputHandler(userupdate obj)
	{
		
			if (StaticVars.Ammo > 0) {
				print ("bang");
				bang (this);
			}
			
		StaticVars.Ammo--;
	}
}
