using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayHighScore : MonoBehaviour {

	private Text text;
	private float displayScore;
	private float highScore;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		if(!PlayerPrefs.HasKey("highscore")){
			PlayerPrefs.SetInt ("highscore", 0);
		}
		text.text = "HIGH SCORE: " + (int)PlayerPrefs.GetInt("highscore");
	}
}
