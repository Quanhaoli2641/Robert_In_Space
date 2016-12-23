using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Camera cam;
	public GameObject player1;
	public GameObject player2;
	public Transform middle;


	public float camMovement;
	private float diffx1,diffx2,diffy1,diffy2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (player1) {
			diffx1 = cam.transform.position.x - player1.transform.position.x;
			diffy1 = cam.transform.position.y - player1.transform.position.y;
		}

		if (player2) {
			diffx2 = cam.transform.position.x - player2.transform.position.x;
			diffy2 = cam.transform.position.y - player2.transform.position.y;
		}

		if (diffx1 < -5f || diffx2 < -5f)
			cam.transform.position = 
				Vector3.MoveTowards (cam.transform.position, 
					new Vector3 (cam.transform.position.x + 15f, cam.transform.position.y, -10f), 
					Time.deltaTime*camMovement);
		if (diffx1 > 5f || diffx2 > 5f)
			cam.transform.position = 
				Vector3.MoveTowards (cam.transform.position, 
					new Vector3 (cam.transform.position.x - 15f, cam.transform.position.y, -10f), 
					Time.deltaTime*camMovement);
		if (diffy1 < -3f || diffy2 < -3f)
			cam.transform.position = 
				Vector3.MoveTowards (cam.transform.position, 
					new Vector3 (cam.transform.position.x, cam.transform.position.y + 15f, -10f), 
					Time.deltaTime*camMovement);
		if (diffy1 > 3f || diffy2 > 3f)
			cam.transform.position = 
				Vector3.MoveTowards (cam.transform.position, 
					new Vector3 (cam.transform.position.x, cam.transform.position.y - 15f, -10f), 
					Time.deltaTime*camMovement);

	}

	void FixedUpdate() {
		
	}
}
