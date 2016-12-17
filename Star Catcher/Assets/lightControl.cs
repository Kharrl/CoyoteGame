using UnityEngine;
using System.Collections;

public class lightControl : MonoBehaviour {
	public Light Red;
	public Light Green;
	// Use this for initialization
	void Start () {
		Red.enabled = true;
		Green.enabled = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		StartCoroutine (SwitchLights ());
	}
	IEnumerator SwitchLights()
	{
		yield return new WaitForSeconds (2f);
		Red.enabled = false;
		Green.enabled = true;
}
}
