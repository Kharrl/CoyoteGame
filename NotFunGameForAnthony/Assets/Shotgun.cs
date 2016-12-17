using UnityEngine;
using System.Collections;

public class Shotgun : WeaponBase, IWeapon {
	
	public void Awake ()
	{
		WeaponDmg = 75;
		WeaponSpeed = 3;
	}
	public void Special ()
	{
		
	}


	public override void ControlHandler (KeyCode _K)
	{
		if (CanFire == true) {
			switch (_K) {
			case KeyCode.Alpha2:
				print ("Reload");
				break;
			case KeyCode.Space:
				UseWeapon ();
				break;
			default:
				break;
			}
		}
	}
}
