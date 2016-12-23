using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class GameOver : MonoBehaviour {


	private Damageable d;
	int health;

	void Start () {
		d = FindObjectOfType<Damageable> ();

	}

	void Update () {
		if (d) health = d.remainingHealth;

		if(health == 0){
			StartCoroutine (gameOver ());
		}

	}

	IEnumerator gameOver() {
		yield return new WaitForSeconds (2f);
		//float fadeTime = GameObject.Find ("MainCamera").GetComponent<Fading> ().beginFade (1);
		//yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene ("GameOver");

	}
}
