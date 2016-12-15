using UnityEngine;
using System.Collections;

public class CoyoteControl : MonoBehaviour {
	public int CoyoteHealth = 1;
	private Vector3 CoyoteJump;
	public GameObject Coyote;
	public SpriteRenderer Art;
	public GameObject death;
	public AudioClip bark;
	private AudioSource source;
	// Use this for initialization
	void Start()
	{
		death.SetActive (false);
		
	}
	void OnTriggerEnter()
	{
		source = GetComponent<AudioSource> ();
		source.PlayOneShot (bark, 1f);
		StartCoroutine (Blink ());
		CoyoteHealth--;
		if (CoyoteHealth <= 0) {
			death.SetActive (true);
			Destroy (Coyote);
		}
	}
	IEnumerator Blink()
	{
		Art.enabled=false;
		yield return new WaitForSeconds (0.1f);
		Art.enabled = true;
		yield return new WaitForSeconds (0.1f);
		Art.enabled = false;
		yield return new WaitForSeconds (0.1f);
		Art.enabled = true;
		yield return new WaitForSeconds (0.1f);
		Art.enabled = false;
		yield return new WaitForSeconds (0.1f);
		Art.enabled = true;

}
}
