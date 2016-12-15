using UnityEngine;
using System.Collections;
using System;

public class Spawner : MonoBehaviour {
	public static Action<Spawner> AddSpawns;
	void Start()
	{
		AddSpawns(this);
}
}