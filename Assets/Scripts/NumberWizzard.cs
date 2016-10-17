using UnityEngine;
using System.Collections;

public class NumberWizzard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Welcome to number wizzard");
		print("Pick a number in your head, but don't tell me.");

		var max = 1000;
		var min = 0;

		print("The highest number you can pick is " + max + "the lowest is " + min);

		print("Is the number higher or lower then 500?");
		print("Press up for higher, down for lower, and return if equal.");



	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up key was pressed");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down key was pressed");
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Return key was pressed");
		}
	}
}
