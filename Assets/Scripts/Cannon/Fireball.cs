using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour {

    public AudioClip sound;

	void Start(){
		Destroy (this.gameObject, 30f);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "PlayerOne" || other.tag == "PlayerTwo"){
			if (!other.GetComponent<Damageable> ().invincible) {
				other.GetComponent<Damageable> ().remainingHealth -= 1;
				other.GetComponent<Damageable> ().partner.GetComponent<Damageable> ().remainingHealth -= 1;
				CameraShaker.hit ();
			}
            AudioSource.PlayClipAtPoint(sound, transform.position);
            Destroy (this.gameObject);
		}
	}
}
