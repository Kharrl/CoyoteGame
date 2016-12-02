using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
	//void Start()
	/*{
		StartNewLevel.NewLevel += NewLevelHandler;
	}*/
	public void OnMouseDown()
			{
		StaticVar.GameClock = 120f;
		StaticVar.StarPower = 50;
		SceneManager.LoadScene(2);
			}
	/*void NewLevelHandler(StartNewLevel obj)
	{
		SceneManager.LoadScene (1);
	}
*/
}
