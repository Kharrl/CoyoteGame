using UnityEngine;
using System.Collections;


public class BlimpRelease : MonoBehaviour {
	public NavMeshAgent coyote;
	// Use this for initialization
	void Start () {
		ExitBlimp.Landed += BlimpReleaseHandler;

	}
	void BlimpReleaseHandler(Transform newPlayer)
	{
		coyote.enabled = true;
		coyote.destination=newPlayer.position;
	}
	// Update is called once per frame
	void Update () {
			
	}
}
