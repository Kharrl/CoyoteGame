using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {
	public float playerspeed =10f;
	private CharacterController myController;
	private Vector3 tempPos;
	private Transform newPos;
	// Use this for initialization
	void Start () {
		myController = GetComponent<CharacterController>();
		userupdate.userinputs += userinputhandler;
	}
	void userinputhandler(userupdate _KeyCode)
	{
		switch (Input) {
		case KeyCode.A:
			tempPos.x = -playerspeed;
			myController.Move (tempPos);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
