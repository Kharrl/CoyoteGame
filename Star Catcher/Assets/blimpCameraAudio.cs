using UnityEngine;
using System.Collections;

public class blimpCameraAudio : MonoBehaviour {
	public AudioListener listen;
	// Use this for initialization
	void Start () {
		listen = GetComponent<AudioListener> ();
		listen.enabled = false;
		getInBlimp.GetIn += listenHandler;
	
	}
	
	// Update is called once per frame
	void listenHandler (getInBlimp _obj) {
		print ("TurnonSound");
		listen.enabled = true;
	}
}
