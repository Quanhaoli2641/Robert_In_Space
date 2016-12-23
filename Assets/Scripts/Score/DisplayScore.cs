using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

	private Text text;
	private float displayScore;
	private float highScore;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		if(!PlayerPrefs.HasKey("highscore")){
			PlayerPrefs.SetInt ("highscore", 0);
		}
		displayScore = PlayerPrefs.GetInt ("currentscore");
		if(displayScore > PlayerPrefs.GetInt("highscore")){
			PlayerPrefs.SetInt ("highscore", (int)displayScore);
			text.text = "NEW HIGH SCORE!! \n\nHIGH SCORE: " + (int)PlayerPrefs.GetInt("highscore");
		}

		else {
			text.text = "SCORE: " + (int)displayScore + "\n\n" + "HIGH SCORE: " + (int)PlayerPrefs.GetInt("highscore");
		}
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
