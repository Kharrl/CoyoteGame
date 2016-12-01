using UnityEngine;
using System.Collections;

public class flipCoyote : MonoBehaviour {
	public SpriteRenderer CoyoteDirection;
		
	// Use this for initialization
	void Start () {
		ChaseBunny.RunSpeeds += RunSpeedsHandler;
		CoyoteDirection = GetComponent<SpriteRenderer> ();
	}
	void RunSpeedsHandler(int direction)
	{
		switch (direction) {
		case -25:
			CoyoteDirection.flipX=false;
			break;
		default:
			CoyoteDirection.flipX = true;
			break;
		}

	}
	// Update is called once per frame
	void Update () {
	
	}
}
