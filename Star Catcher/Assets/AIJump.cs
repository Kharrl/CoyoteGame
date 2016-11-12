using UnityEngine;
using System.Collections;
using System;
public class AIJump : MonoBehaviour {
	public static Action<AIJump> JumpingCoyote;
	void OnTriggerEnter()
	{
		JumpingCoyote (this);
	}
}
