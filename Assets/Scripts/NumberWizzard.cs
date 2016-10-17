using UnityEngine;
using System.Collections;

public class NumberWizzard : MonoBehaviour {
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	private void StartGame() {
		max = max + 1;
		max = 1000;
		min = 0;
		guess = 500;

		print("Welcome to number wizzard");
		print("Pick a number in your head, but don't tell me.");
		print("The highest number you can pick is " + max + "the lowest is " + min);
		print("Is the number higher or lower then " + guess + "?");
		print("Press up for higher, down for lower, and return if equal.");
	}

	private void NextGuess() {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print ("Up = higher, down = lower, return = equal");
	}



	// Update is called once per frame
	private void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print ("Up key was pressed");
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down key was pressed");
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame ();
		}
	}
}
