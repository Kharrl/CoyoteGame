using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetPosition : MonoBehaviour {
	void Start ()
	{
		timer.TimeUP += TimeUpHandler;
		StartNewLevel.NewLevel += StartNewLevelHandler;
		StaticVar.nextSectionPosition = StaticVar.startPosition;
		StaticVar.GameClock = 300f;
	}

	void OnTriggerEnter()
	{
		SceneManager.LoadScene(1);
	}
	void TimeUpHandler(timer obj)
	{
		SceneManager.LoadScene (1);
	}
	void StartNewLevelHandler (StartNewLevel obj)
	{
		SceneManager.LoadScene (1);
	}

}
	
