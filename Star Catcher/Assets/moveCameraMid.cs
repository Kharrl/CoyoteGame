using UnityEngine;
using System.Collections;

public class moveCameraMid : MonoBehaviour {

	void OnTriggerEnter(){
		print ("move Camera");

		GameObject CameraController = GameObject.Find ("Main Camera");
		MoveCamera movecamera = CameraController.GetComponent <MoveCamera> ();
		movecamera.MidCamera();
	}
}
