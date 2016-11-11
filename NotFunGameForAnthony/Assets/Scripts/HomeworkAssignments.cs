using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HomeworkAssignments : MonoBehaviour {
	public int EnemyWave;
	public int numZombies = 10;
	/* Variables are containers that hold various types of data. They can be values
	 * such as int for whole numbers and floats for decimals, they can be game objects,
	 * components, or bools, which are true/false statements. In order to use a variable
	 * in your script you must first declare it like i have above. 
	 */

	// Use this for initialization
	void Start () {
/* Functions are commands that process data in order for your script to do anything
 * While using MonoBehavior, the most common types of functions we use in
 * our class are: Start, which runs once when the script starts, Updates, 
 * which runs once a frame, and OnTriggerEnter which runs when the object is triggered.
 * Functions are the backbone of getting your game to do anything. 
 */
		StartCoroutine (StartWave ());
	}
	IEnumerator StartWave()
	{
		EnemyWave = Random.Range (0, 3);
		
		switch (EnemyWave) {
		case 1:
			print ("zombie 1");
			break;
		case 2:
			print ("Zombie 2");
			break;
		case 3:
			print ("Zombie 3");
			break;
		default: 
			print ("No Zombies");
			break;
			/* If Statements and Switch Statements are conditional statements where
			 * the action of the script is determined by parameters that are set. 
			 * If Statements are better if there's only two scenarios,
			 * either the condition is met or unmet. Switch statements are better 
			 * if there are several different scenarios that all yield different
			 * results. */
		}
		yield return new WaitForSeconds (3);

	
	}
	/* Syntax is the proper format of writing your code in C#. The main points for
	 * your syntax is that you end a line with a semicolon, curly braces denote
	 * groups of commands together. It's important to remember that every open 
	 * brace has a closing brace. Seperate sections of the same command are usually
	 * separated by periods and parenthesis usually denote the parameters of certain
	 * commands or functions.
		*/
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter()
	{
		for (int i = 0; i < numZombies; i++) {
			print ("Raising Zombie #" + i);
		}
		while (numZombies > 0) {
			print ("a new zombie is coming for you");
			numZombies--;
		}
		do 
		{
			print("Get Ready For Zombie Killing");
		}while(numZombies>0);
		/* Loops are a really useful way to repeat code while certain conditions
		 * are true. There are four loops, for, while, do while, and for each. 
		 * The loop that I'm most comfortable with is a while loop, it repeats it's 
		 * coded process while the condition declared is true. Easiest to use by setting
		 * bools.*/
	}
}
/* The Scope of a variable is the range in which that variable is able to be used.
 * If the variable is declared within a specific function, it's usable within that
 * function. If it's declared at the beginning of the script, it's usable throughout 
 * that script. Access modifiers determine what can see the variable. If a variable
 * is private then it can only be seen locally, where as a public variable is able 
 * to be seen not only by other scripts but in the inspector as well, which makes
 * testing and fine tuning a lot simpler. 
 */