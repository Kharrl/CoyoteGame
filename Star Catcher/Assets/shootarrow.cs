using UnityEngine;
using System.Collections;

public class shootarrow : MonoBehaviour {
	public int ArcherNum;
	public Transform ArcherA;
	public Transform ArcherB;
	public Transform ArcherC;
	public Rigidbody Arrow;
	public float thrust=300f;
	public Vector3 ArrowPos;

	// Use this for initialization
	void Start () {
		
		ArcherNum = 2;
		print (ArcherNum);
		FireArrow ();
	}
	void FireArrow()
	{
		switch (ArcherNum) {
		case 2:
			
			Arrow.MovePosition (ArcherA.position);


			Arrow.AddForce (ArcherA.forward * thrust);
			break;
		case 1:
			ArrowPos = ArcherB.position;
			Arrow.AddForce (ArcherB.forward * thrust);
			break;
		default:
			ArrowPos = ArcherC.position;
			Arrow.AddForce (ArcherC.forward * thrust);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
