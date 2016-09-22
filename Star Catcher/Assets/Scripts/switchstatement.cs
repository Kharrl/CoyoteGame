using UnityEngine;
using System.Collections;

public class switchstatement : MonoBehaviour {
	public enum gameStates {Starting, Playing, Ending}	
	public gameStates currentState = gameStates.Starting;

	public void DoSomething(string v, gameStates gs)
	{
		print ("the game is " + v);

		if (gs != gameStates.Ending) {
			Start ();
			currentState = gs;
		}
	}
	void Start()
	{
		switch (currentState)
		{
		case gameStates.Starting:
			DoSomething ("starting", gameStates.Playing);
			break;
		case gameStates.Playing:
			DoSomething ("Playing",gameStates.Ending);
			break;
		case gameStates.Ending:
			DoSomething ("Ending", gameStates.Ending);
			break;
		}

}
}
