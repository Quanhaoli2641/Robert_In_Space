using UnityEngine;
using System.Collections;

public class WallCollision : MonoBehaviour {

	public AudioClip sound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "PlayerOne" || other.gameObject.tag == "PlayerTwo") {
			AudioSource.PlayClipAtPoint(sound, transform.position,200f);
		}
	}
}
