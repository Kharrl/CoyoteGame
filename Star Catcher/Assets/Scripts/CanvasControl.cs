using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasControl : MonoBehaviour {
	public Canvas myCanvas;
	public Camera blimpCamera;
	public Camera finalCam;
	// Use this for initialization
	void Start () {
		KillBunny.Kill += KillHandler;
		ExitBlimp.Landed += LandedHandler;
	}
	
	// Update is called once per frame
	void KillHandler (KillBunny obj) {
		myCanvas.worldCamera = blimpCamera;
	}
	void LandedHandler(Transform obj)
	{
		myCanvas.worldCamera = finalCam;
	}
	void OnDestroy(){
		KillBunny.Kill -= KillHandler;
		ExitBlimp.Landed -= LandedHandler;
	}
}
