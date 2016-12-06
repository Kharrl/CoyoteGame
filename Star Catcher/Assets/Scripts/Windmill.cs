using UnityEngine;
using System.Collections;

public class Windmill : MonoBehaviour {
	public Transform myWindmill;
	public float speed;
	// Use this for initialization
	void Start () {
		speed = Random.Range (0.01f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		myWindmill.Rotate(0,0,speed);
	}
}
