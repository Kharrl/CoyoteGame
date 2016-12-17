using UnityEngine;
using System.Collections;

public class SwitchWeapons : MonoBehaviour {
	public GameObject Axe;
	public GameObject Shotgun;
	// Use this for initialization
	void Start () {
		Updater.Controls += WeaponHandler;
	}
	
	// Update is called once per frame
	void WeaponHandler (KeyCode num)
	{
		switch (num) {
		case KeyCode.Alpha1:
			Axe.SetActive (true);
			Shotgun.SetActive (false);
			break;
		case KeyCode.Alpha2:
			Axe.SetActive (false);
			Shotgun.SetActive (true);
			break;
		default:
			break;

		}
	}
}
