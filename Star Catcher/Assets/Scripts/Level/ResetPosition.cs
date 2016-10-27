using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetPosition : MonoBehaviour {
	void Start ()
	{
		time.TimeUP += TimeUpHandler;
		StaticVar.nextSectionPosition = StaticVar.startPosition;
	}

	void OnTriggerEnter()
	{
		SceneManager.LoadScene(1);
	}
	void TimeUpHandler(time obj)
	{
		SceneManager.LoadScene (1);
	}
}
	
