using UnityEngine;
using System.Collections;

public class time : MonoBehaviour {
	public float myTime = 30.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTime -= Time.deltaTime;
		if (myTime <= 0f)
			print ("Game Over"); 
		if (myTime <= 0f)
			Destroy (this.gameObject);
	}
	void GameClock(){
		myTime = myTime;
		
	
		
	}
}
