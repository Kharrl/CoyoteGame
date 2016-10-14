using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {
	private CharacterController myCC;
	public Vector3 Blimp;
	private Vector3 myPos;
	public Vector3 Boat;
	public float Eject=10f;
	// Use this for initialization
	void Start () {
		myCC = GetComponent<CharacterController> ();

	}
	
	public void EnterBlimp()
	{
		myCC.enabled = false;
		myPos = Blimp;
	
	}
	public void ExitBlimp()
	{
		myPos.y = Eject;
		myPos.x += Eject;
		myCC.enabled = true;

	}

	public void EnterBoat()
	{
		myCC.enabled = false;
		myPos = Boat;
	}
	public void ExitBoat()
	{
		myPos.y = Eject;
		myPos.x = Eject;
		myCC.enabled = true;
	}

}
