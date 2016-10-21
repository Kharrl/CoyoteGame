using UnityEngine;
using System.Collections;
using System;

public class VehicleCamera : MonoBehaviour {
	private Camera myCamera;
	public float ZoomSize = 60f;
	public Transform Greenlandpos;
	public Transform CampCamera;
	// Use this for initialization
	void Start () {
		KillBunny.Kill += KillHandler;
		ExitBlimp.Landed += LandedHandler;
		EnterBoat.HopIn += HopInHandler;
		ExitBoat.Docked += DockedHandler;
		myCamera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void KillHandler(KillBunny obj)
	{
		print ("I should zoom out");
		myCamera.orthographicSize = ZoomSize;

	}
	public void LandedHandler(ExitBlimp obj)
	{
		myCamera.orthographicSize = 25;
		myCamera.transform.position = Greenlandpos.position;
	}
	public void DockedHandler(ExitBoat obj)
	{
		myCamera.orthographic = true;
		myCamera.orthographicSize = 25;
		myCamera.transform.position = CampCamera.position;
	}
	public void HopInHandler(EnterBoat obj)
	{
		myCamera.orthographicSize = ZoomSize;
		myCamera.orthographic = false;


	}
}
