using UnityEngine;
using System.Collections;

public class Axe : WeaponBase{
	public int AxeDmg;
	public int AxeSpeed;


	public void Start () {
		WeaponDmg = AxeDmg;
		WeaponSpeed = AxeSpeed;
		IsRangedWeapon = false;
		Weapon = GetComponent<Transform> ();
		Subscribe ();
	}


}
