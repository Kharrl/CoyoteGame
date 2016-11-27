using UnityEngine;
using System.Collections;

public class SmokeControl : MonoBehaviour {
	public GameObject Smoke1;
	public GameObject Smoke2;
	// Use this for initialization
	void Start () {
		Smoke1.SetActive (false);
		Smoke2.SetActive (false);
		KillBunny.Kill += GetInHandler;
	}
	
	// Update is called once per frame
	void GetInHandler (KillBunny obj) {
		Smoke1.SetActive (true);
		Smoke2.SetActive (true);
	}
}
