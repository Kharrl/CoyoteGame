using UnityEngine;
using System.Collections;

public class newCharacterFlip : MonoBehaviour {
	private CharacterController myCC;
	public Transform CharacterArt;
	private Animator myAnimate;
	// Use this for initialization
	void Start(){
		myCC = GetComponent<CharacterController> ();
		CharacterArt = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (myCC.velocity.x < 0)
			CharacterArt.rotation = new Quaternion (0, 180, 0, 0);
		else
			CharacterArt.rotation = new Quaternion (0, 0, 0, 0);
		
	}
}
