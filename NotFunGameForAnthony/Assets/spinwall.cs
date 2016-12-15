using UnityEngine;
using System.Collections;

public class spinwall : MonoBehaviour {
	public int SpinValue=40;
	private Transform Spinner;
	private Vector3 tempControl;
	// Use this for initialization
	void Start () {
		Spinner = GetComponent<Transform> ();
	}
	void Spin()
	{
		while (SpinValue>=0) {
			tempControl.y = 25;
			Spinner.Rotate (tempControl);
			SpinValue--;
		}
	}
	// Update is called once per frame
	void OnTriggerEnter () {
		
		Spin ();
	}

}
