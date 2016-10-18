using UnityEngine;
using System.Collections;

public class CharacterFlip : MonoBehaviour {

	public Transform characterArt;
	public bool forward = true;
	private Animator myAni;
	// Use this for initialization
	void flipCharacter (KeyCode _keycode)
	{
		switch (_keycode) {
		case KeyCode.RightArrow:
			myAni.enabled = true;
			if (forward == false) {
				characterArt.Rotate (0, 180, 0);
				forward = true;
			}
			break;

		case KeyCode.LeftArrow:
			myAni.enabled=true;
			if (forward == true) {
				characterArt.Rotate (0, -180, 0);
				forward = false;
			}
			break;
		default:
			myAni.enabled = false;
			break;


		}	
			
	}
	void Start()
	{
		myAni = GetComponent<Animator>();
		UserInput.UserInputs += flipCharacter;
		characterArt = this.GetComponent<Transform>();
	}
	void OnDestroy()
	{
		UserInput.UserInputs -= flipCharacter;
	}
}
