using UnityEngine;
using System.Collections;
using System;

public class MoveCamera : MonoBehaviour {
	public float speed = 5f;
	public static Action<GameObject> SpawnBunny;
	public float RaiseCamera = 20f;
	public float LowerCamera = -20f;
	public float GreenlandUp =2.5f;
	private Vector3 tempPosition;
	public float FrozenFall =30f;
	public GameObject Player;
	public GameObject SpawnPlayer;
	public Transform Spawn;
	public Transform CampSpawn;
	public GameObject blimp;
	public void Start()
	{
		ExitBlimp.Landed += LandedHandler;
		ExitBoat.Docked += DockedHandler;
		getInBlimp.GetIn += GetInHandler;
		ElevatorPipe.GoingDown += GoingDownHandler;


	
	}
	// Update is called once per frame
	public void Update () {
		
	

		}
	private void GetInHandler(getInBlimp obj)
	{
		Player = blimp;
	}
	private void LandedHandler(ExitBlimp obj)
	{
		Player=Instantiate (SpawnPlayer, Spawn.position, Spawn.rotation)as GameObject;
		SpawnBunny (Player);

	}
	private void DockedHandler(ExitBoat obj)
	{
		Player=Instantiate (SpawnPlayer, CampSpawn.position, CampSpawn.rotation)as GameObject;

	}
	private void GoingDownHandler(ElevatorPipe obj)
	{
		speed = 0;
	}
}

