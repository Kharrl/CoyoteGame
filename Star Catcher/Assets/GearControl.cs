using UnityEngine;
using System.Collections;

public class GearControl : MonoBehaviour {
	public float GearSpeedZ = 0f;
	public float GearSpeedY = 0f;
	private Transform GearTurn;
	private Rigidbody Gear;
	// Use this for initialization
	void Start () {
		Gear = GetComponent<Rigidbody>();
		GearTurn = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Gear.velocity.x != 0 || Gear.velocity.y != 0) {
			print ("Spin");
			GearTurn.Rotate (0, GearSpeedY, GearSpeedZ);
		}
		else
			GearTurn.Rotate (0, 0, 0);
	}
}
