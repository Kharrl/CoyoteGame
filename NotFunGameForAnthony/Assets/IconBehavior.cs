using UnityEngine;
using System.Collections;

public class IconBehavior : MonoBehaviour {
	public float spinSpeed=5;
	private Vector3 tempPos;
	private Transform icon;
	private float spinner =3f;

	// Use this for initialization
	void Start () {
		icon = GetComponent<Transform> ();
		while (spinner >0)
		{
			tempPos.y = spinSpeed;
			icon.Rotate (tempPos * Time.deltaTime);
			spinner--;
		}
	}
}
