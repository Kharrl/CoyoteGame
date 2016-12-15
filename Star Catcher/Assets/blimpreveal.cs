using UnityEngine;
using System.Collections;

public class blimpreveal : MonoBehaviour {
	public GameObject blimp;

	// Use this for initialization
	void Start () {
		blimp.SetActive (false);
		ExitBlimp.Landed += RevealHandler;
	}
	
	// Update is called once per frame
	void RevealHandler (Transform obj) {
		blimp.SetActive (true);
	}
}
