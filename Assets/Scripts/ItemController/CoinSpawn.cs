using UnityEngine;
using System.Collections;

public class CoinSpawn : MonoBehaviour {

	public GameObject coin;
	private float randomAngle;
	private float randomRadius;
	int randomNum;
	public int large;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//randomAngle = Random.Range (0, 2*Mathf.PI*10000) / 10000;
		//randomRadius = Random.Range (0, 100) / 4;
		randomNum = Random.Range (0, large);
		if (randomNum <= 5) {
			//Instantiate (coin, new Vector2 (randomRadius * Mathf.Cos (randomAngle), randomRadius * Mathf.Sin (randomAngle)), new Quaternion (0, 0, 0, 0));
			Instantiate (coin, 25 * Random.insideUnitCircle, new Quaternion (0, 0, 0, 0));
				
		}
	}
}
