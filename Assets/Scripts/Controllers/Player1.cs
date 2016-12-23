using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

	Rigidbody2D player;
	Vector2 inputVector;
	public float moveSpeed;

	public GameObject g;
	private SpriteRenderer s;

	void Start() {
		player = GetComponent<Rigidbody2D> ();

		s = g.GetComponent<SpriteRenderer> ();
	}

	void Update () {
		inputVector = new Vector2 (0f, 0f);
		if(Input.GetKey(KeyCode.W)){
			inputVector += new Vector2 (0f, 1f);
			s.flipY = false;
		}
		if(Input.GetKey(KeyCode.S)){
			inputVector += new Vector2 (0f, -1f);
			s.flipY = true;
		}
		if(Input.GetKey(KeyCode.A)){
			inputVector += new Vector2 (-1f, 0f);
			s.flipX = false;
		}
		if(Input.GetKey(KeyCode.D)){
			inputVector += new Vector2 (1f, 0f);
			s.flipX = true;
		}
		inputVector = inputVector.normalized;
		}

	void FixedUpdate(){
		player.velocity = (inputVector * moveSpeed);
		var angle = Mathf.Atan2(player.velocity.y, player.velocity.x) * Mathf.Rad2Deg;
		if (player.velocity != new Vector2 (0, 0)) {
			//player.MoveRotation (angle - 90);
			Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 7 * Time.deltaTime);
		}
	}

}
