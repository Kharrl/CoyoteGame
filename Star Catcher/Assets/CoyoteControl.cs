using UnityEngine;
using System.Collections;

public class CoyoteControl : MonoBehaviour {
	public int CoyoteHealth = 1;
	private Vector3 CoyoteJump;
	public float CoyoteJumpSpeed =20f;
	public Transform myJump;
	public GameObject Coyote;
	// Use this for initialization
	void Start()
	{
		AIJump.JumpingCoyote += JumpinCoyoteHandler;
	}
	void OnTriggerEnter()
	{
		CoyoteHealth--;
		if(CoyoteHealth<=0)
			Destroy(Coyote);
	}
	void JumpinCoyoteHandler(AIJump obj)
	{
		CoyoteJump.y = CoyoteJumpSpeed;
		myJump.position = CoyoteJump;
	}
}
