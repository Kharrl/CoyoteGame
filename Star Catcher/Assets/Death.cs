using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	// Use this for initialization
	void Start () {
		KillBunny.Kill += KillHandler;
	}
	
	private void KillHandler(KillBunny obj)
	{
		Destroy (this.gameObject);
	}
}
