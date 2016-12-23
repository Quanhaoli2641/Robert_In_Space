using UnityEngine;
using System.Collections;

public class CannonMovement : MonoBehaviour {

	private Vector3 pos;
	private Vector3 targetAngles;
	public GameObject target;


	public float speed = 10f;

	float time;
	float rotationspeed;

	// Use this for initialization
	void Start () {
		pos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		// rotate around (0, 0)
		pos = Quaternion.AngleAxis(Time.deltaTime * speed, Vector3.back) * pos;
		transform.position = pos;

		// rotate direction that cannon is facing
		Vector2 direction = target.transform.position - transform.position;
		float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
	}
}
