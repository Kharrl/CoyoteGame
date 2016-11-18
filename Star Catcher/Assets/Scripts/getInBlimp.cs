using UnityEngine;
using System.Collections;
using System;

public class getInBlimp : MonoBehaviour {
	public static Action<getInBlimp> GetIn;
	public Camera mycamera;
	public Camera MainCamera;
	public GameObject FirstCam;
	// Use this for initialization
	void Start()
	{
		MainCamera.enabled = true;
		mycamera.enabled = false;
	}
	void OnTriggerEnter()
	{
		GetIn (this);
		MainCamera.enabled = false;
		mycamera.enabled = true;
		FirstCam.SetActive (false);
	}
}
