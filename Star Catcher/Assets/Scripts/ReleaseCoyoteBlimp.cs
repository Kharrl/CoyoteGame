using UnityEngine;
using System.Collections;

public class ReleaseCoyoteBlimp : MonoBehaviour {
	public NavMeshAgent Coyote;
	public float CoyoteSpeed;
	// Use this for initialization
	void Start () {
		ExitBlimp.Landing += LandedHandler;
		CoyoteSpeed = Random.Range (30f, 40f);
	}
	void OnDestroy(){
		ExitBlimp.Landing -= LandedHandler;
	}
	
	void LandedHandler(GameObject obj)
	{
		this.gameObject.SetActive(true);
		Coyote.destination = obj.transform.position;
	}
}
