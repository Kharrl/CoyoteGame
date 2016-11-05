using UnityEngine;
using System.Collections;
using System;

public class userupdate : MonoBehaviour {
	public static Action<userupdate> userinputs;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Mathf.Round(StaticVars.GameTime -= Time.deltaTime);
	}
}
