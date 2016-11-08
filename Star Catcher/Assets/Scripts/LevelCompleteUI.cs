using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelCompleteUI : MonoBehaviour {
	public Text myScore;
	// Use this for initialization
	void Start () {
		myScore.text = "Total Stars Collected: " + StaticVar.StarsCollected;
	}
	

}
