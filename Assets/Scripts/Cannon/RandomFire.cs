using UnityEngine;
using System.Collections;

public class RandomFire : MonoBehaviour {

	public Transform firePoint;
	public float InitialFireRate;
	public GameObject projectile;
	public GameObject projectile2;
	public GameObject projectile3;
	private float currentFireRate;
	private float randomNum;
	private float randomProjNum;
	public float initalTimer;
	private float currTimer;
	public float fireballSpeed;

	void Start() {
		currentFireRate = InitialFireRate;
		currTimer = initalTimer;
	}

	void Update() {
		
		currentFireRate--;
		currTimer--;

	}

	void FixedUpdate() {
		if (currentFireRate <= 0) {
			randomNum = Random.Range(0, 101);
			if (randomNum < 20) {
				randomProjNum = Random.Range(1, 4);
				if (randomProjNum == 1) {
					Object fireball = Instantiate(projectile, firePoint.position, firePoint.rotation);
					((GameObject)(fireball)).GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed * Mathf.Cos(transform.eulerAngles.z * Mathf.PI / 180), fireballSpeed * Mathf.Sin(transform.eulerAngles.z * Mathf.PI / 180));
				}
				if (randomProjNum == 2) {
					Object fireball = Instantiate(projectile2, firePoint.position, firePoint.rotation);
					((GameObject)(fireball)).GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed * Mathf.Cos(transform.eulerAngles.z * Mathf.PI / 180), fireballSpeed * Mathf.Sin(transform.eulerAngles.z * Mathf.PI / 180));
				}
				if (randomProjNum == 3) {
					Object fireball = Instantiate(projectile3, firePoint.position, firePoint.rotation);
					((GameObject)(fireball)).GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed * Mathf.Cos(transform.eulerAngles.z * Mathf.PI / 180), fireballSpeed * Mathf.Sin(transform.eulerAngles.z * Mathf.PI / 180));
				}
			}
			currentFireRate = InitialFireRate;
		}
		if (currTimer <= 0) {
			if (InitialFireRate > 20) {
				InitialFireRate--;
				fireballSpeed += Time.deltaTime*Time.deltaTime;
			}
			currTimer = initalTimer;
		}
	}	
}
