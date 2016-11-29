using UnityEngine;
using System.Collections;

public class BombBehavior : MonoBehaviour {
	public Rigidbody bomb;
	public float ForceSpeed = 3000f;
	public float TorqueSpeed =15000f;
	private Vector3 Force;
	private Vector3 Torques;

	// Use this for initialization
	void Start () {
		bomb = GetComponent<Rigidbody> ();
		StartCoroutine (Move ());
	} 
	void OnTriggerEnter(){
		StopCoroutine (Move ());
		bomb.useGravity = false;
		bomb.isKinematic = true;


	}
	IEnumerator Move()
	{
		
	{
		Force.x = ForceSpeed;
		Torques.y = TorqueSpeed;
		Torques.z = TorqueSpeed;
		bomb.AddForce (Force);
		bomb.AddTorque (Torques);
			yield return new WaitForSeconds(0.01f);
		}
		
}
}
