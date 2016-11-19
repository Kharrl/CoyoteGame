using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {
	public NavMeshAgent myAgent;
	public Transform targetplayer;
	public GameObject playerrespawn;

	// Use this for initialization
	void Start () {
		ExitBlimp.Landed += SpawnBunnyHandler;
	}
	
	// Update is called once per frame
	void Update () {
		myAgent.destination = targetplayer.position;
	}
	void SpawnBunnyHandler(Transform Player)
	{
		
		targetplayer = Player;
	}
}
