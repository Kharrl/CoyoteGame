using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	public float speed = 5f;
	public float RaiseCamera = 20f;
	public float LowerCamera = -20f;
	private Vector3 tempPosition;
	
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
	public void raiseTheCamera()
	{
		StartCoroutine (Raise ());
	}
		public void MidCamera()
	{
		StartCoroutine (Lower ());
	}
}

