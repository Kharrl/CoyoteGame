using UnityEngine;
using System.Collections;
using System;

public class SelectSpawn : MonoBehaviour {
	public static Action<SelectSpawn> front;
	public static Action<SelectSpawn> back;
	private int Selector;
	// Use this for initialization
	void Start () {
		Selector = UnityEngine.Random.Range (1, 2);
		switch (Selector) {
		case 1:
			front (this);
			break;
		case 2:
			back (this);
			break;
		default:
			front (this);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
