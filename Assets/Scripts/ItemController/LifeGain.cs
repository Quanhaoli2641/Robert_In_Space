using UnityEngine;
using System.Collections;

public class LifeGain : MonoBehaviour {

	public GameObject partner;
	public AudioClip sound;

	public ParticleSystem pickup;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "LifeGain") {
			GetComponent<Damageable> ().remainingHealth += 1;
			partner.GetComponent<Damageable> ().remainingHealth += 1;
			AudioSource.PlayClipAtPoint (sound, transform.position, 100f);
			Instantiate (pickup, this.transform.position, this.transform.rotation);
			Destroy (other.gameObject);
		}
	}
}
