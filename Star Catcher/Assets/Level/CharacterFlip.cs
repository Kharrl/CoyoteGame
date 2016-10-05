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
			characterArt.Rotate(0,180,0);
			break;

		case KeyCode.LeftArrow:
			characterArt.Rotate(0,180,0);
			break;
		}	
			
	}
	void Start()
	{
		
		UserInput.UserInputs += flipCharacter;
	}
}
