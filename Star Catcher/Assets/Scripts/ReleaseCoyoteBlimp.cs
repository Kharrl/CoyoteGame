using UnityEngine;
using System.Collections;

public class ReleaseCoyoteBlimp : MonoBehaviour {
	public NavMeshAgent Coyote;
	public float CoyoteSpeed;
	// Use this for initialization
	void Start () {
		ExitBlimp.Landed += LandedHandler;
		CoyoteSpeed = Random.Range (30f, 40f);
	}
	
	void LandedHandler(Transform obj)
	{
		this.gameObject.SetActive(true);
	}
}
