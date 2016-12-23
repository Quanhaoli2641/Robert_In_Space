using UnityEngine;
using System.Collections;

public class ItemSpawner : MonoBehaviour {

	public GameObject o;
	private Vector3 center;

	public string[] tags;
	private Object n;

	public float spawnTime;
	private float counter;

	// Use this for initialization
	void Start () {

		center = transform.position;
		tags [0] = "SpeedPowerUp";
		tags [1] = "SizeDebuff";
		tags [2] = "Shield";
		counter = spawnTime;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (counter > 0)
			counter--;
		else if (counter <= 0) {
			float angle = Random.value * 360;
			float random = Random.Range (0, 20);
			Vector3 pos;
			pos.x = center.x + random * Mathf.Sin (angle * Mathf.Deg2Rad);
			pos.y = center.y + random * Mathf.Cos (angle * Mathf.Deg2Rad);
			pos.z = center.z;
			n = Instantiate (o, pos, transform.rotation);
			int ranTag = (int)Mathf.Round (Random.value*2);
			if (n)
				((GameObject)n).tag = (string)(tags [ranTag]);
			counter = spawnTime;
		}
	
	}
}
