using UnityEngine;
using System.Collections;

public class MoveCameraUp : MonoBehaviour {
	
	void OnTriggerEnter(){
		print ("move Camera");
	
		GameObject CameraController = GameObject.Find ("Main Camera");
		MoveCamera movecamera = CameraController.GetComponent <MoveCamera> ();
		movecamera.raiseTheCamera();
	}
}

