using UnityEngine;
using System.Collections;

public class GearControl : MonoBehaviour {
	public float GearSpeedZ = 0f;
	public float GearSpeedY = 0f;
	private Transform GearTurn;
	public bool TurnGears = false;
	// Use this for initialization
	void Start () {
		RidetheLift.Triggered += TriggeredHandler;
		StopGears.GearStop += GearStopHandler;
		GearTurn = GetComponent<Transform> ();
	}
	void Update(){
		if(TurnGears==true)
		GearTurn.Rotate (0, GearSpeedY, GearSpeedZ);
	}
	// Update is called once per frame
	void TriggeredHandler (RidetheLift obj) {
		TurnGears = true;

	}
	IEnumerator StopLift()
	{
		yield return new WaitForSeconds (2);
		TurnGears = false;
	}
	void GearStopHandler(StopGears obj)
	{
		StartCoroutine (StopLift ());
	}
	void OnDestroy(){
		RidetheLift.Triggered -= TriggeredHandler;
	}
}
