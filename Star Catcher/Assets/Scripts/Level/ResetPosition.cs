using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetPosition : MonoBehaviour {
	void Start ()
	{
		StaticVar.nextSectionPosition = StaticVar.startPosition;
	}

	void OnTriggerEnter()
	{
		SceneManager.LoadScene(0);
	}
	public void Restarts()
	{
		SceneManager.LoadScene (0);
	}
}
	
