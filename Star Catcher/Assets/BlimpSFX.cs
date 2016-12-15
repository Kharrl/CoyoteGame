using UnityEngine;
using System.Collections;

public class BlimpSFX : MonoBehaviour {
	public AudioClip blimp;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		getInBlimp.GetIn += BlimpSFXHandler;
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void BlimpSFXHandler (getInBlimp obj) {
		print ("blimp");
		source.PlayOneShot(blimp,1f);
	}
}
