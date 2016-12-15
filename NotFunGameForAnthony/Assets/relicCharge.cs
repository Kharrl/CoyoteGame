using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class relicCharge : MonoBehaviour {
	public int healthbar;
	public List <GameObject>MyList;
	// Use this for initialization
	void Start () {columndmg.killem+=KillEmHandler;
		EnemyBase.AddMe += AddemHandler;
	}
	void AddemHandler(GameObject obj)
	{
		MyList.Add (obj);
	}
	// Update is called once per frame
	void KillEmHandler (int R) {
		healthbar = R;
		StartCoroutine(Combat ());
	}
	IEnumerator Combat()
	{
		yield return new WaitForSeconds (3);
		foreach (GameObject obj in MyList)
			healthbar-=10;
	}

}
