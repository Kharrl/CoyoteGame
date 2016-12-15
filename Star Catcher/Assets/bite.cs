using UnityEngine;
using System.Collections;

public class bite : MonoBehaviour {
	public AudioClip growl;
	private AudioSource source;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		source = GetComponent<AudioSource> ();
		source.PlayOneShot (growl, 1f);
	}
}
