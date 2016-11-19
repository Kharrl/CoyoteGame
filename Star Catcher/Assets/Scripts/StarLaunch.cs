using UnityEngine;
using System.Collections;

public class StarLaunch : MonoBehaviour {
	public Transform LaunchA;
	public Transform LaunchB;
	public Transform LaunchC;
	public Transform LaunchD;
	public Rigidbody Star;
	public int LaunchSelect;
	private Rigidbody starInstance;
	// Use this for initialization
	void Start () {
		LaunchSelect = Random.Range (0, 3);
		StartCoroutine (LaunchStar ());
	}
	
	IEnumerator LaunchStar()
	{
		yield return new WaitForSeconds(2);
		switch(LaunchSelect)
		{
		case 1:
			starInstance = Instantiate (Star, LaunchA.position, Quaternion.identity) as Rigidbody;

			break;
		case 2:
			starInstance = Instantiate (Star, LaunchB.position, Quaternion.identity) as Rigidbody;

			break;
		case 3:
			starInstance = Instantiate (Star, LaunchC.position, Quaternion.identity) as Rigidbody;

			break;
		default:
			starInstance = Instantiate (Star, LaunchD.position, Quaternion.identity) as Rigidbody;
		
			break;


	}
		Start ();
}
}