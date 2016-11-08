using UnityEngine;
using System.Collections;
public class StarBehavior : MonoBehaviour {
	// Use this for initialization
	private bool canAddForce=true;
	public float forceDuration = 0.1f;
	private Rigidbody  Starbody;
	private float force;
	public float torquespeed =3000f;
	private Vector3 forcevector;
	private Vector3 torquevector;
	public float ForceRange = 10000f;
	void Start () {
		Starbody = this.GetComponent<Rigidbody> ();
		StarCollect.IsCollected += CollectionHandler;
		StartCoroutine (DestroyStar ());
		StartCoroutine (Spins ());
		ForceStarForward.AddForceForward += AddForceForwardHandler;
		ForceStarBack.AddBackForce += AddBackForceHandler;


	}
	void AddForceForwardHandler(ForceStarForward _obj)
	{
		StartCoroutine (runForce ());
	}
	void AddBackForceHandler(ForceStarBack _obj)
	{
		StartCoroutine (MinusForce ());	
	}
	IEnumerator MinusForce()
	{
		while (canAddForce == true) {
			yield return new WaitForSeconds (forceDuration);
			forcevector.x = -ForceRange;
			Starbody.AddForce (forcevector);
		}
	}
	IEnumerator runForce()
	{
		
		while (canAddForce == true) {
			yield return new WaitForSeconds (forceDuration);
			forcevector.x = ForceRange;
			Starbody.AddForce (forcevector);
		}
	}
	// Update is called once per frame
	IEnumerator DestroyStar()
	{
		print ("not Collected");
		yield return new WaitForSeconds (6);
		Destroy (this.gameObject);

}
	IEnumerator StarCollects()
	{
		
		if (StaticVar.StarPower < StaticVar.MaxStarPower) {
			StaticVar.StarPower += 10;
			print (StaticVar.StarPower);
		}
		StaticVar.StarsCollected++;
		print (StaticVar.StarsCollected);
		Destroy (this.gameObject);
		yield return null;
}
	void CollectionHandler(StarCollect obj)
	{
		StartCoroutine (StarCollects ());
	}
	void OnDestroy()
	{
		StarCollect.IsCollected -= CollectionHandler;
		ForceStarBack.AddBackForce -= AddBackForceHandler;
		ForceStarForward.AddForceForward -= AddForceForwardHandler;
	}
	void OnCollisionEnter()
	{
		canAddForce = false;
	}
		IEnumerator Spins()
		{
			torquevector.y=torquespeed;
			yield return new WaitForSeconds(forceDuration);
			Starbody.AddTorque(torquevector);
		}
}
