using UnityEngine;
using System.Collections;

public class PowerUpSpeed : MonoBehaviour {

    public AudioClip sound;

	public GameObject player1;
	public GameObject player2;
	public Camera cam;

	public ParticleSystem pickup;
	private Player1 r1;
	private Player2 r2;
	private CameraController c;

	public float timer;
	private float innerTimer;
	private int numOfTimes;

	// Use this for initialization
	void Start () {
		
		numOfTimes = 0;
		innerTimer = timer;
		r1 = player1.GetComponent<Player1> ();
		r2 = player2.GetComponent<Player2> ();
		c = cam.GetComponent<CameraController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (numOfTimes > 0) {
			innerTimer--;
		}
		if (innerTimer <= 0) {
			r1.moveSpeed /= 2;
			r2.moveSpeed /= 2;
			c.camMovement /= 2;
			innerTimer = timer;
			numOfTimes -= 1;
		}
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "SpeedPowerUp") {
			r1.moveSpeed *= 2;
			r2.moveSpeed *= 2;
			c.camMovement *= 2;
			numOfTimes += 1;
            AudioSource.PlayClipAtPoint(sound, transform.position,100f);
			Instantiate (pickup, this.transform.position, this.transform.rotation);
            Destroy (other.gameObject);
		}
	}
}
