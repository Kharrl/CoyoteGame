using UnityEngine;
using System.Collections;

public class IFStatement : MonoBehaviour {

	public bool isDoorUnlocked = false;

	void Start(){
		if (isDoorUnlocked) {
			enter ();
		} else {
			Exit ();
		}
	}
	void enter ()
	{
		print("Speak friend and enter");
	}
	void Exit ()
	{
		print("the way is shut -He is coming!");
	}
}