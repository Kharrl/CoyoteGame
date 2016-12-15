using UnityEngine;
using System.Collections;
using System;

public class VehicleCamera : MonoBehaviour {
	private Camera myCamera;
	public float ZoomSize = 60f;
	public Transform Greenlandpos;
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
	public void LandedHandler(Transform obj)
	{
		myCamera.orthographicSize = 30;

	}
	public void DockedHandler(ExitBoat obj)
	{
		myCamera.orthographic = true;
		myCamera.orthographicSize = 25;

	}
	public void HopInHandler(EnterBoat obj)
	{
		myCamera.orthographicSize = ZoomSize;
		myCamera.orthographic = false;


	}
	void OnDestroy()
	{
		KillBunny.Kill -= KillHandler;
		ExitBlimp.Landed -= LandedHandler;
		EnterBoat.HopIn -= HopInHandler;
		ExitBoat.Docked -= DockedHandler;
	}
}
