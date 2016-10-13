using UnityEngine;
using System.Collections;

public class enemycontrol : MonoBehaviour {
	public CharacterController dumbname;
	public float gravity= 1f;
	public Vector3 tempPosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tempPosition.y -= gravity * Time.deltaTime;
		dumbname.Move (tempPosition);
	}
}
