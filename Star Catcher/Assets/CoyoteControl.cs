using UnityEngine;
using System.Collections;

public class CoyoteControl : MonoBehaviour {
	public int CoyoteHealth = 3;
	private Vector3 CoyoteJump;
	public float CoyoteJumpSpeed =20f;
	public Transform myJump;
	// Use this for initialization
	void Start()
	{
		myJump = this.transform;
		AIJump.JumpingCoyote += JumpinCoyoteHandler;
	}
	void OnTriggerEnter()
	{
		CoyoteHealth--;
		if(CoyoteHealth<=0)
			Destroy(this.gameObject);
	}
	void JumpinCoyoteHandler(AIJump obj)
	{
		CoyoteJump.y = CoyoteJumpSpeed;
		myJump.position = CoyoteJump;
	}
}
