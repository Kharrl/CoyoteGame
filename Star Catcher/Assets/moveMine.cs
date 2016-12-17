using UnityEngine;
using System.Collections;

public class moveMine : MonoBehaviour {
	public float MoveSpeed;
	public Transform Mine;
	public Vector3 tempPos;
	// Use this for initialization
	void Start () {
		

	
	}
	
	// Update is called once per frame
	void Update () {
		tempPos.y = MoveSpeed * Time.deltaTime;
		Mine.Translate (tempPos);
	}
	IEnumerator SwitchDirection()
	{
		print ("Switch");
		MoveSpeed = MoveSpeed * -1;
		yield return new WaitForSeconds (1);
	}
	void OnTriggerEnter()
	{
		StartCoroutine (SwitchDirection ());
	}
}
