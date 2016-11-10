using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class displayUI : MonoBehaviour {
	public Text CollectedStars;
	public Text GameTimer;
	public Slider Health;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CollectedStars.text = "Stars Collected:"+StaticVar.StarsCollected;
		GameTimer.text = ""+Mathf.Round (StaticVar.GameClock-=Time.deltaTime);
		if (StaticVar.GameClock <= 0f) {
			SceneManager.LoadScene (2);
		}
	}
}
