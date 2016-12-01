using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LogoScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (GoToSplashScreen ());
	}
	
	IEnumerator GoToSplashScreen()
	{
		yield return new WaitForSeconds (3f);
		SceneManager.LoadScene (1);
	}
}
