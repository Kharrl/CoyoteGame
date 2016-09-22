using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {
	public string firstName;
	public string lastName;
	private string userName;
	private int userNum;

	void OnMouseDown ()
	{
		userNum = Random.Range (1,9999);
		print (UserInfo());
		print ("this is your username "+userName);
	}

	string UserInfo()
	{
		return firstName + " " + lastName + " are you ready to play?";
		userName = firstName + lastName+ userNum;
	}
}
