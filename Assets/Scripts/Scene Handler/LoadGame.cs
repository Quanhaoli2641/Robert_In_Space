using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {

	public Text play;
	public Text menu;
	public Image playborder;
	public Image menuborder;

	public AudioSource src;

	void Start () {
		playborder.enabled = true;
		menuborder.enabled = false;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) {
			playborder.enabled = !playborder.enabled;
			menuborder.enabled = !menuborder.enabled;
			src.Play ();
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			if (playborder.enabled) {
				SceneManager.LoadScene("GAME");
			}
			else if (menuborder.enabled) {
				SceneManager.LoadScene("TitleScene");
			}
		}
	}
}
