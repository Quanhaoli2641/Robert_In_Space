using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Damageable : MonoBehaviour{

    public AudioClip sound;

	public Text text;

    public int remainingHealth = 3;
	public GameObject partner;

	public Image heart1;
	public Image heart2;
	public Image heart3;

	public bool invincible;
	private float counter;

	public GameObject shield;

	void Start() {
		invincible = false;
		counter = 10f;
	}

    void Update()
    {

		if (invincible) {
			counter -= Time.deltaTime;
			shield.SetActive (true);
		}

		if (counter <= 0) {
			invincible = false;
			shield.SetActive (false);
			counter = 10f;
		}

        if (remainingHealth <= 0)
        {
            AudioSource.PlayClipAtPoint(sound, transform.position, 200f);
            Destroy (partner);
			Destroy(gameObject);

			//gameOver();
        }

		text.text = "Lives: ";

		if (remainingHealth > 3) {
			remainingHealth = 3;
		}

		if (remainingHealth == 0) {
			heart1.enabled = false;
			heart2.enabled = false;
			heart3.enabled = false;
		}

		if (remainingHealth == 1) {
			heart1.enabled = true;
			heart2.enabled = false;
			heart3.enabled = false;
		}

		if (remainingHealth == 2) {
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = false;
		}

		if (remainingHealth == 3) {
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = true;
		}

    }

	/*public void gameOver() {
		SceneManager.LoadScene ("GameOver");
	}*/

}
