using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	public float speed = 5f;
	public float RaiseCamera = 20f;
	public float LowerCamera = -20f;
	public float GreenlandUp =2.5f;
	private Vector3 tempPosition;
	void Start()
	{
		MoveCameraUp.Lift += LiftHandler;
		moveCameraMid.Drop += DropHandler;
		GreenlandCamera.Hill += HillHandler;
	}
	// Update is called once per frame
	void Update () {
		tempPosition.x = speed * Time.deltaTime;
		transform.Translate (tempPosition);
	}
	IEnumerator Raise ()
	{


			tempPosition.y = RaiseCamera*Time.deltaTime;
			transform.Translate(tempPosition);
			
		yield return null;
		yield return new WaitForSeconds (2);
		tempPosition.y = 0 * Time.deltaTime;
		transform.Translate (tempPosition);
	}
	IEnumerator Lower ()
	{
		
			tempPosition.y = LowerCamera * Time.deltaTime;
			transform.Translate (tempPosition);

		yield return null;
		yield return new WaitForSeconds(2);
		tempPosition.y=0*Time.deltaTime;
		transform.Translate(tempPosition);
	}
	IEnumerator GreenlandRaise()
	{
		tempPosition.y = GreenlandUp * Time.deltaTime;
		transform.Translate (tempPosition);
		yield return null;
		tempPosition.y = 0 * Time.deltaTime;
		transform.Translate (tempPosition);
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
}

