using UnityEngine;
using System.Collections;



public class bombSFX : MonoBehaviour {
	private AudioSource source;
	public AudioClip Boom;
	private float MinVol = 0.5f;
	private float MaxVol = 1f;
	public GameObject Bomb;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		
		float vol = Random.Range (MinVol, MaxVol);
		source.PlayOneShot (Boom, vol);
	}
	void BlowUP()
	{
		Bomb.SetActive (false);
	}
}
