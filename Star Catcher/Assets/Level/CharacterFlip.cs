using UnityEngine;
using System.Collections;

public class CharacterFlip : MonoBehaviour {

	public Transform characterArt;
	public bool forward = true;
	// Use this for initialization
	void flipCharacter (KeyCode _keycode)
	{
		switch (_keycode) {
		case KeyCode.RightArrow:
			if (forward == false) {
				characterArt.Rotate (0, 180, 0);
				forward = true;
			}
			break;

		case KeyCode.LeftArrow:
			if (forward == true) {
				characterArt.Rotate (0, -180, 0);
				forward = false;
			}
			break;


		}	
			
	}
	void Start()
	{
		
		UserInput.UserInputs += flipCharacter;
		characterArt = this.GetComponent<Transform>();
	}
}
