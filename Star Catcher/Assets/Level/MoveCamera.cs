using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	public float speed = 5f;
	private Vector3 tempPosition;
	
	// Update is called once per frame
	void Update () {
		tempPosition.x = speed * Time.deltaTime;
		transform.Translate (tempPosition);
	}
}
