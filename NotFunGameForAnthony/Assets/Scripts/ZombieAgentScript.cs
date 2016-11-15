using UnityEngine;
using System.Collections;

public class ZombieAgentScript : MonoBehaviour {
	public NavMeshAgent Zombies;
	public Transform Player;
	// Use this for initialization
	void Start () {
		userupdate.fakeUpdate += ZombieStalkHandler;
		ZombieBehavior.Redead += RedeadHandler;
	}
	void ZombieStalkHandler(userupdate obj)
	{
		Zombies.destination = Player.position;
	}
	void RedeadHandler(ZombieBehavior obj)
	{
		Destroy (this);
	}
	void OnDestroy()
	{
		userupdate.fakeUpdate -= ZombieStalkHandler;
		ZombieBehavior.Redead -= RedeadHandler;
	}
}
