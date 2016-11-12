using UnityEngine;
using System.Collections;

public class ReleaseTheCoyote : MonoBehaviour {
	private NavMeshAgent myAgent;
	public float SpawnTime;
	// Use this for initialization
	void Start () {
		myAgent = GetComponent<NavMeshAgent> ();
		SpawnTime = Random.Range (5f, 10f);
		myAgent.enabled = false;
		StartCoroutine (CoyoteActive ());
	}
	
	// Update is called once per frame
	IEnumerator CoyoteActive()
	{
		yield return new WaitForSeconds (SpawnTime);
		myAgent.enabled = true;
	}
}
