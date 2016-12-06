using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class RetryLevel : MonoBehaviour {

	public void OnClick(){
		StaticVar.GameClock = 120f;
		StaticVar.StarPower = 50;
		SceneManager.LoadScene (2);
}
}