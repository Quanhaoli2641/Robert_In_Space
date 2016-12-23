using UnityEngine;
using UnityEngine.SceneManagement; // need this to change scene in game
using System.Collections;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			SceneManager.LoadScene("GAME");
		}
	}
}
