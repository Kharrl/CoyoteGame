using UnityEngine;
using System.Collections;

public class HurtSFX : MonoBehaviour {
	public AudioClip grunt;
	private AudioSource source;
	private float MinVol= 0.5f;
	private float MaxVol= 1f;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		HurtBunny.BunnyHit += HurtHandler;
	}
	
	// Update is called once per frame
	void HurtHandler (HurtBunny obj) {
		float vol = Random.Range (MinVol, MaxVol);
		source.PlayOneShot (grunt, vol);
	}
	void OnDestroy(){
		HurtBunny.BunnyHit -= HurtHandler;
	}
}
