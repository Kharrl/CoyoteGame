using UnityEngine;
using System.Collections;

public class CharacterSlide : MonoBehaviour {
	private CharacterController mycc;
	public int slideDuration = 10;
	public float slideTime = 0.01f;


	IEnumerable Slide()
	{
		int i =0;
		while (i < slideDuration) {
			i++;
			yield return new WaitForSeconds (slideTime);
			print ("Sliding");
		}
	}
	// Use this for initialization
	void Start() {
		mycc = GetComponent<CharacterController> ();
		StartCoroutine (Slide());
	}
	

}
