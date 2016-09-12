using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {
	public Rigidbody Ball;
	public float Xplace;
	public float Zplace;
	public float Yplace;
	public float ballsize;
	public int playerscore = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Ball.transform.Rotate (new Vector3 (0, 5, 0));
		Xplace = Random.Range (-3f, 3f);
		Zplace = Random.Range (-3f, 3f);
		Yplace = Random.Range (0f, 4f);
		ballsize = Random.Range (.25f, 1.5f);
		
	}
	void OnMouseDown()
	{
		Ball.transform.localScale = new Vector3 (ballsize, ballsize, ballsize);
		Ball.transform.localPosition = new Vector3 (Xplace, Yplace, Zplace);
		playerscore = playerscore + 1;
		print(playerscore);

	}
}
