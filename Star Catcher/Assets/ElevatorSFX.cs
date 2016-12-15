using UnityEngine;
using System.Collections;

public class ElevatorSFX : MonoBehaviour {
	public AudioClip Elevator;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		RidetheLift.Triggered += liftHandler;
	}
	
	// Update is called once per frame
	void liftHandler(RidetheLift _obj) {
		source.PlayOneShot (Elevator, 0.1f);
	}
}
