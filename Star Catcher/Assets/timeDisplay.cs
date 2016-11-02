using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timeDisplay : MonoBehaviour {
	public Text TimeText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		TimeText.text = "Time:"+ (StaticVar.GameClock-=Time.deltaTime);
	}
}
