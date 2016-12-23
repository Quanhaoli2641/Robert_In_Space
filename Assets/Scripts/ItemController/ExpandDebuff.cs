using UnityEngine;
using System.Collections;

public class ExpandDebuff : MonoBehaviour {


	public GameObject player1;
	public GameObject player2;
	public Camera cam;
	public ParticleSystem pickup;
	private Transform r1;
	private Transform r2;

	public float timer;
	private float innerTimer;

	public AudioClip sound;

	public float a;

	private int numOfTimes;

	// Use this for initialization
	void Start () {
		innerTimer = timer;
		r1 = player1.transform;
		r2 = player2.transform;
		numOfTimes = 0;
	}

	// Update is called once per frame
	void Update () {

		if (numOfTimes > 0)
			innerTimer--;
		if (innerTimer <= 0) {
			r1.localScale = new Vector3 (r1.localScale.x / a, r1.localScale.y / a, r1.localScale.z / a);
			r2.localScale = new Vector3 (r2.localScale.x / a, r2.localScale.y / a, r2.localScale.z / a);
			innerTimer = timer;
			numOfTimes -= 1;
		}

	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "SizeDebuff") {
			r1.localScale = new Vector3 (r1.localScale.x * a, r1.localScale.y * a, r1.localScale.z * a);
			r2.localScale = new Vector3 (r2.localScale.x * a, r2.localScale.y * a, r2.localScale.z * a);
			numOfTimes++;

			AudioSource.PlayClipAtPoint(sound, transform.position,100f);
			Instantiate (pickup, this.transform.position, this.transform.rotation);
			Destroy (other.gameObject);
		}
	}
}
