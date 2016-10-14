using UnityEngine;
using System.Collections;
using System;



public class UserInput : MonoBehaviour {
	public static Action<KeyCode> UserInputs;
	private Animator myAnimate;
	// Use this for initialization
	void Start () {
		myAnimate = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow) && UserInputs != null) 
		{
			UserInputs (KeyCode.RightArrow);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow) && UserInputs != null)
		{
			UserInputs (KeyCode.LeftArrow);
		}	
		if (Input.GetKeyUp (KeyCode.RightArrow) && UserInputs != null) {
			myAnimate.enabled = false; 
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow) && UserInputs != null) {
			myAnimate.enabled = false;
		}
	 
	}
}
