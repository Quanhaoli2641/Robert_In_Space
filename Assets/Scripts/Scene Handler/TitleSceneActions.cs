using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleSceneActions : MonoBehaviour {

	public Text help;
	public Text start;
	public Image helpborder;
	public Image startborder;
	public AudioSource src;

	void Start () {
		helpborder.enabled = false;
		startborder.enabled = true;
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) {
			helpborder.enabled = !helpborder.enabled;
			startborder.enabled = !startborder.enabled;
			src.Play();
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			if (helpborder.enabled) {
				SceneManager.LoadScene("HelpScene");
			}
			else if (startborder.enabled) {
				SceneManager.LoadScene("GAME");
			}
		}
	}
}
