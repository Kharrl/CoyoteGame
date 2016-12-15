using UnityEngine;
using System.Collections;
using System;

public class Axe : WeaponBase, IWeapon {
	public float KnockBack = 30f;
	public static Action <float>SendKnockback;
	public void Awake(){
		WeaponDmg = 50;
		WeaponSpeed = 1;
	}// Use this for initialization
	void Start () {
		Updater.Controls += ControlHandler;
	}
	
	// Update is called once per frame
	override public void  ControlHandler (KeyCode K) {
		if(CanFire==true){
		switch(K)
		{
		case KeyCode.Space:
			
			UseWeapon ();
			break;
		default:
			break;
		}
		}
	}

	public void Special ()
	{
		SendKnockback(KnockBack);
	}
}
