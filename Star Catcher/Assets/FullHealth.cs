using UnityEngine;
using System.Collections;

public class FullHealth : MonoBehaviour {
	public GameObject explosion;
	public GameObject Explosion;
	// Use this for initialization
	void Awake () {
		HealthSlider.checkHealth += checkHealthHandler;
		explosion.SetActive (false);
		Explosion.SetActive (false);
	}
	
	// Update is called once per frame
	void checkHealthHandler () {
		StartCoroutine (Burst ());
	}
	IEnumerator Burst()
	{
		if (StaticVar.StarPower >= 100)
		{explosion.SetActive (true);
			Explosion.SetActive (true);
		}
		
		yield return new WaitForSeconds (1f);
		Explosion.SetActive(false);
			explosion.SetActive (false);
		
	}
	void OnDestroy()
	{
		HealthSlider.checkHealth -= checkHealthHandler;
	}
}
