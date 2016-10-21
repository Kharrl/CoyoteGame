using UnityEngine;
using System.Collections;

public class BoatController : MonoBehaviour {
	public float boatSpeed = 20f;
	private Transform boatStart;
	private Vector3 TempPos;
	private CharacterController BoatControl;
	// Use this for initialization
	void Start () {
		BoatControl=this.GetComponent<CharacterController> ();
		boatStart = this.GetComponent<Transform> ();
		TempPos = boatStart.position;
		BoatControl.enabled = false;
		EnterBoat.HopIn = HopInHandler;
		ExitBoat.Docked += DockedHandler;
	}
	IEnumerator EnteringBoat()
	{
		BoatControl.enabled = true;
		yield return null;
	}
	IEnumerator ExitingBoat()
	{
		BoatControl.enabled = false;
		yield return null;
	}
	public void HopInHandler(EnterBoat _obj)
	{

		StartCoroutine (EnteringBoat ());
	}
	// Update is called once per frame
	void Update () {
		TempPos.x = boatSpeed * Input.GetAxis ("Horizontal");
		TempPos.z = boatSpeed * Input.GetAxis ("Vertical");
		BoatControl.Move (TempPos * Time.deltaTime);
	}
	public void DockedHandler(ExitBoat obj)
	{
		StartCoroutine (ExitingBoat ());
	}
}
