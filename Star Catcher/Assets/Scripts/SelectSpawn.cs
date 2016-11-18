using UnityEngine;
using System.Collections;
using System;

public class SelectSpawn : MonoBehaviour {
	public static Action<SelectSpawn> front;
	public static Action<SelectSpawn> back;
	private int Selector;
	public GameObject CoyoteFront;
	public GameObject CoyoteBack;
	// Use this for initialization
	void Start () {
		Selector = UnityEngine.Random.Range (1, 2);
		SendAction ();

	}
	
	// Update is called once per frame
	void SendAction()
	{
		switch (Selector) {
		case 1:
			CoyoteFront.SetActive(true);
			break;
		case 2:
			CoyoteBack.SetActive (true);
			break;
		default:
			front (this);
			break;
		}
	}
}
