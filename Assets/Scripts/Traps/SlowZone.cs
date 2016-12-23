using UnityEngine;
using System.Collections;

public class SlowZone : MonoBehaviour {

	public int slowness;

	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "PlayerOne") {
			other.GetComponent<Player1> ().moveSpeed = (other.GetComponent<Player1> ().moveSpeed / slowness);
		}
		if (other.tag == "PlayerTwo") {
			other.GetComponent<Player2> ().moveSpeed = (other.GetComponent<Player2> ().moveSpeed / slowness);
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "PlayerOne") {
			other.GetComponent<Player1> ().moveSpeed = (other.GetComponent<Player1> ().moveSpeed * slowness);
		}
		if (other.tag == "PlayerTwo") {
			other.GetComponent<Player2> ().moveSpeed = (other.GetComponent<Player2> ().moveSpeed * slowness);
		}
	}
}
