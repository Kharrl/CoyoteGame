using UnityEngine;
using System.Collections;
using System;

public class ElevatorPipe : MonoBehaviour {
	public static Action<ElevatorPipe> GoingDown;
	public float down = 10f;
	private Vector3 tempPos;
	private MeshCollider myMesh;
	public Transform StartPos;
	void Start()
	{
		myMesh = this.GetComponent<MeshCollider> ();
		ElevatorExit.BottomButton += BottomButtonHandler;
	}
	// Use this for initialization
	void OnTriggerEnter()
	{
		tempPos.y = -down * Time.deltaTime;
		transform.Translate (tempPos);
		GoingDown (this);

	}
	IEnumerator MeshDissolve()
	{
		myMesh.enabled = false;
		yield return new WaitForSeconds (1);
		myMesh.enabled = true;
		tempPos = StartPos.position;
		yield return null;
	}

	public void BottomButtonHandler(ElevatorExit obj)
	{
		StartCoroutine (MeshDissolve ());
	}


}
