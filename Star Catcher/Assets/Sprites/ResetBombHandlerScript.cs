using UnityEngine;
using System.Collections;

public class ResetBombHandlerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ResetBomb.DestroyBomb += ResetBombHandler;
	}
	
	// Update is called once per frame
	void ResetBombHandler() {
		Destroy(this.gameObject);
	}
	void OnDestroy()
	{
		ResetBomb.DestroyBomb -= ResetBombHandler;
	}

}
