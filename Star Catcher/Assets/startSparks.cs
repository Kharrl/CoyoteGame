using UnityEngine;
using System.Collections;

public class startSparks : MonoBehaviour {
	public GameObject Sparky;
	// Use this for initialization
	void Start () {
		Sparky.SetActive (false);
		RidetheLift.Triggered += TriggeredHandler;
	}
	
	// Update is called once per frame
	void TriggeredHandler (RidetheLift obj) {
		Sparky.SetActive (true);
	}
	void OnDestroy(){
		RidetheLift.Triggered -= TriggeredHandler;
	}
}
