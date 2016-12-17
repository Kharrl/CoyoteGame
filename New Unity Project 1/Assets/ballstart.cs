using UnityEngine;
using System.Collections;

public class ballstart : MonoBehaviour {
	public Rigidbody ballRB;
	// Use this for initialization
	void Start () {
		ballRB = GetComponent<Rigidbody> ();
		ballRB.AddForce (Vector3.left * 2000);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
