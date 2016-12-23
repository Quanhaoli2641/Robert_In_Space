using UnityEngine;
using System.Collections;

public class CameraShaker : MonoBehaviour {

	private Camera cam;

	Vector3 startPosition;
	static float shakeStrength = 0f;
	static bool impact;


	// Use this for initialization
	void Start () {
		impact = false;
		cam = FindObjectOfType<Camera> ();
		startPosition = cam.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if(!impact) startPosition = cam.transform.position;

		shakeStrength = Mathf.Clamp (shakeStrength - Time.deltaTime, 0f, 1f);


		if (impact) {
			cam.transform.position = startPosition
				+ shakeStrength * (
			    	cam.transform.right * Mathf.Sin (Time.time * 30f) * 0.5f
			    	+ cam.transform.up * Mathf.Sin (Time.time * 20f) * 0.5f
				);
		}
		if (shakeStrength <= 0f) {
			impact = false;
		}

	}

	public static void hit() {
		impact = true;
		shakeStrength = 1f;
	}
}
