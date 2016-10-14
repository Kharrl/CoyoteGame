﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Recyclecomponent : MonoBehaviour {
	private Vector3 newLocation;
	public List<Recycling> recyclableList;
	private int i;






	void OnTriggerEnter()
	{
		i = Random.Range (0, recyclableList.Count-1);
		print (i);
		StaticVar.nextSectionPosition += StaticVar.distance;
		newLocation.x = StaticVar.nextSectionPosition;
		recyclableList [i].terrain.position = newLocation;
		recyclableList.Remove (recyclableList[i]);
		recyclableList [i].canberecycled = false;

		print (newLocation);

	}
	// Use this for initialization
	void Start () {
		recyclableList=new List<Recycling>();
		Recycling.RecycleAction += RecycleActionHandler;

	}
	private void RecycleActionHandler(Recycling obj)
	{
		
		recyclableList.Add (obj);
	}
	// Update is called once per frame
	void Update () {
	
	}
}