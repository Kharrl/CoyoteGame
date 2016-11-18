using UnityEngine;
using System.Collections;

public class CameraAgent : MonoBehaviour{
	public Transform Player;
	public NavMeshAgent CamAgent;
	public Transform Blimp;
	public Transform newTransorm;
	// Use this for initialization
	void Start () {
		KillBunny.Kill += KillHandler;
		MoveCamera.SpawnBunny += SpawnHandler;
		newTransorm = Player;
	}
	
	// Update is called once per frame
	void Update () {
		CamAgent.destination = newTransorm.position;
	}
	void SpawnHandler(GameObject Bunny)
	{
		newTransorm.position = Bunny.transform.position;
	}
	void KillHandler(KillBunny obj)
	{
		newTransorm.position = Blimp.transform.position;
	}
}
