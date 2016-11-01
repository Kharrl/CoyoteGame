using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {
	public Vector3 myPos;
	public Transform nextPos;
	public float speed = 4f;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		myPos.x = speed * Time.deltaTime;
		transform.Translate (myPos);
	}
		
}
