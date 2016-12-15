using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class RetryLevel : MonoBehaviour {
	public AudioClip click;
	private AudioSource source;
	public void OnClick(){
		source = GetComponent<AudioSource> ();
		source.PlayOneShot (click, 1f);
		StaticVar.GameClock = 120f;
		StaticVar.StarPower = 50;
		SceneManager.LoadScene (2);
}
}