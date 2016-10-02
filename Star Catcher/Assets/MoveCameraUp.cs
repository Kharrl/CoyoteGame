using UnityEngine;
using System.Collections;

public class MoveCameraUp : MonoBehaviour {
	public Camera myCamera;
	public float raiseCamera = 22f;
	private Vector3 camPos;

	void OnTriggerEnter(){
		while (myCamera.transform.position.y < 22)
			camPos.y = raiseCamera * Time.deltaTime;
		
	}

}
