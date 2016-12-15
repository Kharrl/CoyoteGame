using UnityEngine;
using System.Collections;
using System;
public class WeaponBase : MonoBehaviour {
	public static Action<int> FireWep;
	public int WeaponDmg;
	public int WeaponSpeed;
	public bool CanFire=true;
	// Use this for initialization
	void Start () {
		Updater.Controls += ControlHandler;
	}
	public void UseWeapon()
	{
		StartCoroutine (FireWeapon ());
	}
	// Update is called once per frame
	public virtual void ControlHandler (KeyCode _K) {
		
			
	}
	IEnumerator FireWeapon()
	{
		CanFire = false;
		print ("fire");
		FireWep (WeaponDmg);
		yield return new WaitForSeconds (WeaponSpeed);
		CanFire = true;
	}
}
