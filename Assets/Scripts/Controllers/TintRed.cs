using UnityEngine;
using System.Collections;


public class TintRed : MonoBehaviour {

	float clicks;
	float timer;

	// Use this for initialization
	void Start () {

		clicks = 0;
		timer = 0.1f;
		GetComponent<SpriteRenderer> ().color = Color.white;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (clicks > 0) {
			timer -= Time.deltaTime;
			if (GetComponent<SpriteRenderer> ().color == Color.red && timer <= 0) {
				GetComponent<SpriteRenderer> ().color = Color.white;
				timer = 0.1f;
				clicks -= 1;
			}
			else if (GetComponent<SpriteRenderer> ().color == Color.white && timer <= 0){
				GetComponent<SpriteRenderer> ().color = Color.red;
				timer = 0.1f;
			}
		}

	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Fireball" && !GetComponent<Damageable>().invincible) {
			clicks = 3;
		}
	}
}
