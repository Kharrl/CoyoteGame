using UnityEngine;
using System.Collections;

public class ZombieAgentScript : MonoBehaviour {
	public NavMeshAgent Zombies;
	public Transform Player;
	public Transform Respawn;
	// Use this for initialization
	void Start () {
		userupdate.fakeUpdate += ZombieStalkHandler;
	}
	void ZombieStalkHandler(userupdate obj)
	{
		Zombies.destination = Player.position;
	}
	public void KillZombie()
	{
		transform.position=Respawn.position;

	}
	void OnDestroy()
	{
		userupdate.fakeUpdate -= ZombieStalkHandler;
	}
}
