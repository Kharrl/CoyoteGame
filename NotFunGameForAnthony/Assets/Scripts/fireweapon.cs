using UnityEngine;
using System.Collections;
using System;

public class fireweapon : MonoBehaviour {
	public static Action<fireweapon> bang;
	void Start()
	{
		userupdate.fakeUpdate += UserInputHandler;
	}
	// Use this for initialization
	void UserInputHandler(userupdate obj)
	{
		
		if (Input.GetKeyDown(KeyCode.Space))
			{
			Shoot ();
			}
			

	}
	public void Shoot()
	{
		print("Bang");
		StartCoroutine(ShootZombies());
	}
	public IEnumerator ShootZombies()
	{
		print("GunFired");
		bang(this);
		yield return null;
		StopCoroutine (ShootZombies ());
}
}