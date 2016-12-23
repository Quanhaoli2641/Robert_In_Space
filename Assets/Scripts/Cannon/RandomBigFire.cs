using UnityEngine;
using System.Collections;

public class RandomBigFire : MonoBehaviour {

	public Transform firePoint;
	public GameObject projectile;
	public int counter;
	public int timer;
	public float projectileSize;
	public float fireballSpeed;

	void Start() {
		projectileSize = 10;
		timer = 1000;
		counter = timer;
	}

	void Update() {

	}

	void FixedUpdate() {
		counter--;
		if (counter <= 0) {
			Object fireball = Instantiate(projectile, firePoint.position, firePoint.rotation);
			((GameObject)(fireball)).GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed * Mathf.Cos(transform.eulerAngles.z * Mathf.PI / 180), fireballSpeed * Mathf.Sin(transform.eulerAngles.z * Mathf.PI / 180));
			Vector3 scale = ((GameObject)(fireball)).transform.localScale;
			scale.x *= projectileSize;
			scale.y *= projectileSize;
			((GameObject)(fireball)).transform.localScale = scale;
			counter = timer;
		}
	}	
}
