
using UnityEngine;
using System.Collections;
using System;



public class userupdate : MonoBehaviour {
	public static Action<KeyCode> UserInputs;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow) && UserInputs!=null) 
		{
			UserInputs (KeyCode.RightArrow);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow) && UserInputs != null)
		{
			UserInputs (KeyCode.LeftArrow);
		}	
		if (Input.GetKeyDown (KeyCode.UpArrow) && UserInputs != null) {
			UserInputs (KeyCode.UpArrow);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow) && UserInputs != null) {
			UserInputs (KeyCode.DownArrow);
		}
		if (Input.GetKeyDown (KeyCode.Space) && UserInputs != null) {
			UserInputs (KeyCode.Space);
		}

	}

}


