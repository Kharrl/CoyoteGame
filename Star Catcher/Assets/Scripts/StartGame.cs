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
		SceneManager.LoadScene(1);
			}
	/*void NewLevelHandler(StartNewLevel obj)
	{
		SceneManager.LoadScene (1);
	}
*/
}
