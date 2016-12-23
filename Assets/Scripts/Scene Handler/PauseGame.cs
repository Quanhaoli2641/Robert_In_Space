using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {

	public Image backgroundImage;
	public Text restart;
	public Text mainMenu;

	public Image restartBorder;
	public Image mainMenuBorder;

	public GameObject background;
	public AudioSource src;
	public AudioSource option;


	// Use this for initialization
	void Start () {
		backgroundImage.enabled = false;
		restart.enabled = false;
		mainMenu.enabled = false;
		restartBorder.enabled = false;
		mainMenuBorder.enabled = false;
	}

	void controls(){
		if(Time.timeScale == 0){
			
			if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) {
				restartBorder.enabled = !restartBorder.enabled;
				mainMenuBorder.enabled = !mainMenuBorder.enabled;
				option.Play ();
			}
			if (Input.GetKeyDown(KeyCode.Space)) {
				if (restartBorder.enabled) {
					Time.timeScale = 1;
					SceneManager.LoadScene("GAME");
				}
				else if (mainMenuBorder.enabled) {
					Time.timeScale = 1;
					SceneManager.LoadScene("TitleScene");
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		controls ();
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(Time.timeScale == 1){
				Time.timeScale = 0;
				src.Pause ();
				background.GetComponent<CoinSpawn> ().enabled = false;
				background.GetComponent<HeartSpawn> ().enabled = false;
				background.GetComponent<ItemSpawner> ().enabled = false;
				backgroundImage.enabled = true;
				restart.enabled = true;
				mainMenu.enabled = true;
				restartBorder.enabled = true;
				mainMenuBorder.enabled = false;
			}
			else{
				Time.timeScale = 1;
				src.UnPause ();
				background.GetComponent<CoinSpawn> ().enabled = true;
				background.GetComponent<HeartSpawn> ().enabled = true;
				background.GetComponent<ItemSpawner> ().enabled = true;
				backgroundImage.enabled = false;
				restart.enabled = false;
				mainMenu.enabled = false;
				restartBorder.enabled = false;
				mainMenuBorder.enabled = false;
			}
		}
	}
}
