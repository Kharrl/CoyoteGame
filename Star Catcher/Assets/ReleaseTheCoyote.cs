using UnityEngine;
using System.Collections;

public class ReleaseTheCoyote : MonoBehaviour {
	private NavMeshAgent myAgent;
	public float CoyoteSpeed;
	public int SpawnTime;
	public GameObject Coyote;
	// Use this for initialization
	void Start () {
		myAgent = GetComponent<NavMeshAgent> ();

		SpawnTime = Random.Range (5, 10);
		CoyoteSpeed = Random.Range (15f, 45f);
		myAgent.enabled = false;
		Coyote.SetActive (false);
		SelectSpawn.front += SelectionHandler;
		StartCoroutine (CoyoteActive ());
	}
	void SelectionHandler(SelectSpawn obj)
	{
		StartCoroutine (CoyoteActive ());
	}
	// Update is called once per frame
	IEnumerator CoyoteActive()
	{
		yield return new WaitForSeconds (SpawnTime);
		myAgent.speed = CoyoteSpeed;
		myAgent.enabled = true;
		Coyote.SetActive (true);
	}
}
