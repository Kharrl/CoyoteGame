using UnityEngine;
using System.Collections;

public class movebomb : MonoBehaviour {
	public Transform store;
	public Transform tempPos;
	// Use this for initialization
	void OnTriggerEnter(){
		tempPos = store;
	}
}
