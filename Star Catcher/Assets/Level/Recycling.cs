using UnityEngine;
using System.Collections;
using System;


public class Recycling : MonoBehaviour {
	public static Action<Recycling> RecycleAction;
	public bool canberecycled= false;
	public Transform terrain;
	// Use this for initialization
	void Start () {
		terrain = this.GetComponent<Transform>();
		if (RecycleAction != null&&canberecycled)
			RecycleAction (this);
	}
	void OnTriggerEnter()
	{
		canberecycled = true;
		Start ();
	}
}
