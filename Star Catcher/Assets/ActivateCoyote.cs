using UnityEngine;
using System.Collections;

public class ActivateCoyote : MonoBehaviour {
	public Transform player;
	public NavMeshAgent coyote;

	void Start(){
		coyote = GetComponent<NavMeshAgent> ();
		coyote.enabled = false;
		ExitBlimp.Landed = LandedHandler;
	}
	void LandedHandler(Transform newPlayer)
	{
		player = newPlayer;
		coyote.destination = player.position;
	}
	void OnWillRenderObject()
	{
		coyote.enabled = true;
	}


}
