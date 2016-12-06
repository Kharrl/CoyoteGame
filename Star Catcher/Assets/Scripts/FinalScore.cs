using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FinalScore : MonoBehaviour {
	public Text myText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myText.text = "Total Stars: " + StaticVar.StarsCollected;
	}
}
