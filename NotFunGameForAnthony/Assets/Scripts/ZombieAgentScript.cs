using UnityEngine;
using System.Collections;

public class ZombieAgentScript : MonoBehaviour {
	public NavMeshAgent Zombies;
	public Transform Player;
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
		Destroy (this);

	}
	void OnDestroy()
	{
		userupdate.fakeUpdate -= ZombieStalkHandler;
	}
}
