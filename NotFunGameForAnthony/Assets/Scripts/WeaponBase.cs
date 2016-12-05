using UnityEngine;
using System.Collections;
using System;

public class WeaponBase : MonoBehaviour {
	public static Action<float> SendDmg;
	public float WeaponDmg;
	public float WeaponSpeed;
	public bool IsRangedWeapon;
	public Transform Player;
	public Transform Weapon;


	// Use this for initialization
	public void Subscribe () {
		userupdate.UserInputs += UserInputHandler;
	}
	
	// Update is called once per frame
	public void UserInputHandler (KeyCode _K) {
		switch(_K)
		{
		case KeyCode.Z:
			if (IsRangedWeapon == true)
				StartCoroutine (WeaponDelay ());
			break;
		case KeyCode.X:
			if (IsRangedWeapon == false)
				print ("Swing");
				StartCoroutine (MeleeAttack ());
			break;
		default:
			break;
	}
}
	IEnumerator WeaponDelay()
	{
		SendDmg (WeaponDmg);
		yield return new WaitForSeconds (WeaponSpeed);
	}
	public IEnumerator MeleeAttack()
	{
		Weapon.RotateAround (Player.position, Vector3.up, 3590f*Time.deltaTime);
		yield return new WaitForSeconds (1f);
		Weapon.RotateAround (Player.position, Vector3.down, -3590f*Time.deltaTime);

	
	}
}
