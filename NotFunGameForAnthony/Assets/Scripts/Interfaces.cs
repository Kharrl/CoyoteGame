using UnityEngine;
using System.Collections;

public interface IWeapon{ 

	int WeaponSpeed();
	int WeaponDmg();

}
public interface IEnemy{
	int Health();
	int StalkSpeed ();
	void Attack ();
}
