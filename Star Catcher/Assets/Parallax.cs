using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {
	public Vector3 myPos;
	public Transform nextPos;
	public float speed = 4f;
	public float RaiseCamera= 5f;
	public float LowerCamera= 5f;
	public float GreenlandUp=2.5f;

	// Use this for initialization
	void Start () {
		MoveCameraUp.Lift += LiftHandler;
		moveCameraMid.Drop += DropHandler;
		GreenlandCamera.Hill += HillHandler;
		GreenlandDowns.Decent += DecentHandler;
	}

	// Update is called once per frame
	void Update () {
		myPos.x = speed * Time.deltaTime;
		transform.Translate (myPos);
	}
	void OnTriggerEnter()
	{
		myPos = nextPos.position;
}
	IEnumerator Raise ()
	{


		myPos.y = RaiseCamera*Time.deltaTime;
		transform.Translate(myPos);

		yield return null;
		yield return new WaitForSeconds (2);
		myPos.y = 0 * Time.deltaTime;
		transform.Translate (myPos);
	}
	IEnumerator Lower ()
	{

		myPos.y = -LowerCamera * Time.deltaTime;
		transform.Translate (myPos);

		yield return null;
		yield return new WaitForSeconds(2);
		myPos.y=0*Time.deltaTime;
		transform.Translate(myPos);
	}
	IEnumerator GreenlandRaise()
	{
		myPos.y = GreenlandUp * Time.deltaTime;
		transform.Translate (myPos);
		yield return new WaitForSeconds (6);
		yield return null;
		myPos.y = 0 * Time.deltaTime;
		transform.Translate (myPos);
	}
	IEnumerator GreenlandDrop()
	{
		myPos.y = -GreenlandUp * Time.deltaTime;
		transform.Translate (myPos);
		yield return null;
		myPos.y = 0 * Time.deltaTime;
		transform.Translate (myPos);
	}
	private void LiftHandler(MoveCameraUp Obj)
	{
		StartCoroutine (Raise ());
	}
	private void DropHandler(moveCameraMid Obj)
	{
		StartCoroutine (Lower ());
	}
	private void HillHandler(GreenlandCamera Obj)
	{
		StartCoroutine (GreenlandRaise ());
	}
	private void DecentHandler (GreenlandDowns obj)
	{
		StartCoroutine (GreenlandDrop ());
	}
		
}
