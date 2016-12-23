using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class HelpSceneActions : MonoBehaviour {

	public Text objectivetitle;
	public Text objectivedetails;
	public Text poweruptitle;
	public Text powerupdetails;

	public Image powerupimage;

	public Text controlstitle;
	public Text controlsdetails;
	public Text playernumbers;

	public Image wasd;
	public Image arrows;

	public Text next;
	public Text back;

	public Text heartandcoinstitle;
	public Text heartandcoinsdetails;

	public Image heart;
	public Image coin;

	void Start () {
		next.enabled = true;
		back.enabled = true;
		showObjective();
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			if (objectivetitle.enabled) {
				showHeartAndCoin ();
			}
			else if (heartandcoinstitle.enabled) {
				showPowerUps ();
			}
			else if (poweruptitle.enabled) {
				showControls();
			}
			else if (controlstitle.enabled) {
				SceneManager.LoadScene("GAME");
			}
		}
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (objectivetitle.enabled) {
				SceneManager.LoadScene("TitleScene");
			}
			else if (heartandcoinstitle.enabled) {
				showObjective ();
			}
			else if (poweruptitle.enabled) {
				showHeartAndCoin ();
			}
			else if (controlstitle.enabled) {
				showPowerUps();
			}
		}
	}

	void showObjective() {
		objectivetitle.enabled = true;
		objectivedetails.enabled = true;
		heartandcoinstitle.enabled = false;
		heartandcoinsdetails.enabled = false;
		heart.enabled = false;
		coin.enabled = false;
		poweruptitle.enabled = false;
		powerupdetails.enabled = false;
		powerupimage.enabled = false;
		controlstitle.enabled = false;
		controlsdetails.enabled = false;
		playernumbers.enabled = false;
		wasd.enabled = false;
		arrows.enabled = false;
		next.text = "next (SPACE) >>";
		back.text = "<< main menu (ESC)";
	}

	void showHeartAndCoin() {
		objectivetitle.enabled = false;
		objectivedetails.enabled = false;
		heartandcoinstitle.enabled = true;
		heartandcoinsdetails.enabled = true;
		heart.enabled = true;
		coin.enabled = true;
		poweruptitle.enabled = false;
		powerupdetails.enabled = false;
		powerupimage.enabled = false;
		controlstitle.enabled = false;
		controlsdetails.enabled = false;
		playernumbers.enabled = false;
		wasd.enabled = false;
		arrows.enabled = false;
		next.text = "next (SPACE) >>";
		back.text = "<< back (ESC)";
	}

	void showPowerUps() {
		objectivetitle.enabled = false;
		objectivedetails.enabled = false;
		heartandcoinstitle.enabled = false;
		heartandcoinsdetails.enabled = false;
		heart.enabled = false;
		coin.enabled = false;
		poweruptitle.enabled = true;
		powerupdetails.enabled = true;
		powerupimage.enabled = true;
		controlstitle.enabled = false;
		controlsdetails.enabled = false;
		playernumbers.enabled = false;
		wasd.enabled = false;
		arrows.enabled = false;
		next.text = "next (SPACE) >>";
		back.text = "<< back (ESC)";
	}
		
	void showControls() {
		objectivetitle.enabled = false;
		objectivedetails.enabled = false;
		heartandcoinstitle.enabled = false;
		heartandcoinsdetails.enabled = false;
		heart.enabled = false;
		coin.enabled = false;
		poweruptitle.enabled = false;
		powerupdetails.enabled = false;
		powerupimage.enabled = false;
		controlstitle.enabled = true;
		controlsdetails.enabled = true;
		playernumbers.enabled = true;
		wasd.enabled = true;
		arrows.enabled = true;
		next.text = "start game (SPACE) >>";
		back.text = "<< back (ESC)";
	}
}
