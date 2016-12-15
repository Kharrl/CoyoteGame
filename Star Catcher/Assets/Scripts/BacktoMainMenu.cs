using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class BacktoMainMenu : MonoBehaviour {
	public AudioClip click;
	private AudioSource source;
	// Use this for initialization
	public void OnClick(){
		source = GetComponent<AudioSource> ();
		source.PlayOneShot (click, 1);
		SceneManager.LoadScene (0);
	}
}
