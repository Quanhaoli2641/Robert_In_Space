using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

	public Text text;
	public float score = 0;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("currentscore", 0);
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + (int)score;
		score += Time.deltaTime;
		PlayerPrefs.SetInt ("currentscore", (int)score);
		//FindObjectOfType<DisplayScore> ().displayScore = score;
	}
}
