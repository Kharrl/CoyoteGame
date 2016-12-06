using UnityEngine;
using System.Collections;

public class ActivateCoyote : MonoBehaviour {
	public Transform player;
	public NavMeshAgent coyote;

	void Start(){
		coyote = GetComponent<NavMeshAgent> ();
		ExitBlimp.Landed = LandedHandler;
	}
	void LandedHandler(Transform newPlayer)
	{
		player = newPlayer;
		coyote.destination = player.position;
	}


}
