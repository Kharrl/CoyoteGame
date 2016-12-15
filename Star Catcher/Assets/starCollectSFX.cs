using UnityEngine;
using System.Collections;

public class starCollectSFX : MonoBehaviour {
	public AudioClip Collect;
	private AudioSource source;
	private float MinVol = 0.5f;
	private float MaxVol =1f;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		StarCollect.IsCollected += CollectedHandler;
		VehicleStars.BlimpCollect += BlimpHandler;
	}
	
	// Update is called once per frame
	void CollectedHandler (StarCollect obj) {
		float vol = Random.Range (MinVol, MaxVol);
		source.PlayOneShot (Collect, vol);
	}
	void BlimpHandler(){
		float vol = Random.Range (MinVol, MaxVol);
		source.PlayOneShot (Collect, vol);
	}
}
