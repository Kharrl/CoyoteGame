using UnityEngine;
using System.Collections;
using System;



public class UserInput : MonoBehaviour {
	public static Action<KeyCode> UserInputs;
	public bool isIdle = true;
	private Animator myAnimate;
	public bool CanFlip = true;
	// Use this for initialization
	void Start () {
		myAnimate = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow) && UserInputs!=null) 
		{
				UserInputs (KeyCode.RightArrow);
			isIdle = false;
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow) && UserInputs != null)
		{
			UserInputs (KeyCode.LeftArrow);
				isIdle=false;
		}	
		if (Input.GetKeyUp (KeyCode.RightArrow)&& UserInputs!= null)
		{
			
			isIdle=true;
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow) && UserInputs!=null)
		{
			isIdle=true;
		}
		myAnimate.SetBool("Idling",isIdle);
	 
	}

}
