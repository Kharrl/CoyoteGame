using UnityEngine;
using System.Collections;
public class QuitGame : MonoBehaviour {
	public AudioClip click;
	private AudioSource source;
	// Use this for initialization
	public void OnClick(){
		source = GetComponent<AudioSource> ();
		source.PlayOneShot (click, 1f);
		Application.Quit();

	}
}
