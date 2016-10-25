using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log ("Level load requested for " + name);
	}

	public void QuitRequest() {
		Debug.Log ("Quit Requested");
	}
}
