using UnityEngine;
using System.Collections;

public class DisplayTime : MonoBehaviour {
	public TextEditor timedisplay;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timedisplay.text = "Time:" + StaticVar.GameClock;
	}
}
