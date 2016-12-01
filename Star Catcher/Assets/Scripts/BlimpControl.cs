using UnityEngine;
using System.Collections;

public class BlimpControl : MonoBehaviour {
	public float blimpSpeed = 20f;
	private Transform blimpStart;
	private Vector3 TempPos;
	private CharacterController BlimpController;
	// Use this for initialization
	void Start () {
		BlimpController=this.GetComponent<CharacterController> ();
		blimpStart = this.GetComponent<Transform> ();
		TempPos = blimpStart.position;
		BlimpController.enabled = false;
		getInBlimp.GetIn = TurnBlimpOnHandler;
		ExitBlimp.Landed = LandedHandler;
	}
	IEnumerator EnterBlimp()
	{
		BlimpController.enabled = true;
		yield return null;
	}
	IEnumerator ExitingBlimp()
	{
		this.gameObject.SetActive (false);
		BlimpController.enabled = false;
		yield return null;
	}
	public void TurnBlimpOnHandler(getInBlimp _obj)
	{
		
		StartCoroutine (EnterBlimp ());
	}
	// Update is called once per frame
	void Update () {
		TempPos.x = blimpSpeed * Input.GetAxis ("Horizontal");
		TempPos.y = blimpSpeed * Input.GetAxis ("Vertical");
		BlimpController.Move (TempPos * Time.deltaTime);
	}
	public void LandedHandler(Transform _obj)
	{
		StartCoroutine (ExitingBlimp ());
	}
	void OnDestroy()
	{
		ExitBlimp.Landed -= LandedHandler;
	}
}
