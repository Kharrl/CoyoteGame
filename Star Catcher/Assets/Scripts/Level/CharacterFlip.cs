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
			if (forward == false&&!Input.GetKeyDown(KeyCode.LeftArrow)) {
				characterArt.Rotate (0, 180, 0);
				forward = true;
			}
			break;

		case KeyCode.LeftArrow:
			if (forward == true&&!Input.GetKeyDown(KeyCode.RightArrow)) {
				characterArt.Rotate (0, -180, 0);
				forward = false;
			}
			break;
		default:
			break;


		}	
			
	}
	void Start()
	{
		UserInput.UserInputs += flipCharacter;
		characterArt = this.GetComponent<Transform>();


	}

	void OnDestroy()
	{
		UserInput.UserInputs -= flipCharacter;
	}

}
