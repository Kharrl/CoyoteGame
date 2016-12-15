using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private CharacterController MyCC;
	public Transform Player;
	private Vector3 MoveMe;
	private Vector3 TurnMe;
	public float MoveSpeed;
	public float TurnSpeed;
	// Use this for initialization
	void Start () {
		MyCC = GetComponent<CharacterController> ();
		Player = GetComponent<Transform> ();
		Updater.Movement += MoveHandler;
		Updater.Turning += TurnHandler;
	}
	
	// Update is called once per frame
	void MoveHandler(float _M) {
		transform.Translate (Vector3.forward * MoveSpeed * _M * Time.deltaTime);
		MoveMe.y=-8f;
		MyCC.Move (MoveMe); 
	}
	void TurnHandler(float _T)
	{
		TurnMe.y = TurnSpeed * _T * Time.deltaTime;
		Player.Rotate (TurnMe);
}
}
