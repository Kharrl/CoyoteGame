﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void OnMouseDown()
			{
		SceneManager.LoadScene(Random.Range(1,4));
			}
	

}