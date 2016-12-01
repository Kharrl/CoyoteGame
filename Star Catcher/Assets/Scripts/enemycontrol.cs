using UnityEngine;
using System.Collections;

public class enemycontrol : MonoBehaviour {
	public CharacterController dumbname;
	public float gravity= 1f;
	public Vector3 tempPosition;
	private float Run;

	// Use this for initialization
	void Start () {
		ChaseBunny.RunSpeeds += ChaseBunnyHandler;
	}
	void ChaseBunnyHandler(int newSpeed)
	{
		Run = newSpeed;
	}
	// Update is called once per frame
	void Update () {
		tempPosition.x = Run * Time.deltaTime;
		tempPosition.y -= gravity * Time.deltaTime;
		dumbname.Move (tempPosition);
	}
}
