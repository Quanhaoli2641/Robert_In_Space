using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public AudioClip sound;
	public ParticleSystem pickup;

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "PlayerOne" || other.tag == "PlayerTwo") {
			other.GetComponent<PlayerScore> ().score += 10;
			other.GetComponent<Damageable> ().partner.GetComponent<PlayerScore> ().score += 10;
            AudioSource.PlayClipAtPoint(sound, transform.position, 100f);
			Instantiate (pickup, this.transform.position, this.transform.rotation);
			Destroy (gameObject);
		}
		if(other.tag == "Wall"){
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 30f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
