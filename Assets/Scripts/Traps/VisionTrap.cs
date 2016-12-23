using UnityEngine;
using System.Collections;

public class VisionTrap : MonoBehaviour {

	public new Camera camera;
	static bool inside;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame


	void Update () {

		if(!inside){
			if (camera.orthographicSize < 8) {
				camera.orthographicSize += Time.deltaTime;
			}
		}
	}

	void OnTriggerStay2D(Collider2D other){
		if ((other.tag == "PlayerOne") || (other.tag == "PlayerTwo")) {
			if (camera.orthographicSize > 5) {
				camera.orthographicSize -= Time.deltaTime;
			}
			inside = true;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if ((other.tag == "PlayerOne") || (other.tag == "PlayerTwo")) {
			inside = false;
		}
	}
}
