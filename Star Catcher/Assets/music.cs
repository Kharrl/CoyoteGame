using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {
	public AudioClip clips;
	private AudioSource source;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		source.PlayOneShot (clips, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
