using UnityEngine;
using System.Collections;
using System;

public class WeaponBase : MonoBehaviour {
	public static Action<float> SendDmg;
	public float WeaponDmg;
	public float WeaponSpeed;
	public bool IsRangedWeapon;
	public Transform Player;


	// Use this for initialization
	void Start () {
		userupdate.UserInputs += UserInputHandler;
	}
	
	// Update is called once per frame
	void UserInputHandler (KeyCode _K) {
		switch(_K)
		{
		case KeyCode.Z:
			if (IsRangedWeapon == true)
				StartCoroutine (WeaponDelay ());
			break;
		case KeyCode.X:
			if (IsRangedWeapon == false)
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
	IEnumerator MeleeAttack()
	{
		this.transform.RotateAround (Player.position, Vector3.up, 90*Time.deltaTime);
		yield return new WaitForSeconds (WeaponSpeed);
		this.transform.RotateAround (Player.position, Vector3.up, -90 * Time.deltaTime);
		yield return new WaitForSeconds (WeaponSpeed);
		StopCoroutine (MeleeAttack ());
	}
}
