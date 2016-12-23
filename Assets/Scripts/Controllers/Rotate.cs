using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



		transform.eulerAngles = new Vector3 (0f, 0f, transform.eulerAngles.z - 100*Time.deltaTime);
	
	}
}
