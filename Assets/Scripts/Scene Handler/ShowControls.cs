using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowControls : MonoBehaviour {

	public Text title;
	public Text subtitle;

	public Text p1;
	public Text p2;

	public Text startText;

	public GameObject wasd;
	public GameObject arrows;

	public bool start;
	public int time;

	public float titleDist;
	public float subDist;
	public float pDist;

	bool hPressed;

	// Use this for initialization
	void Start () {
		start = false;
		time = 50;

		titleDist = title.transform.position.y / 27.0f;
		subDist = subtitle.transform.position.y / (-26.0f);

		pDist = p1.transform.position.y / (-49.5f);

		startText.transform.localScale = new Vector3(0f, 0f, 0f);

		hPressed = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		if (Input.GetKeyDown(KeyCode.H)) {
			if (hPressed == false) {
				start = true;
				hPressed = true;
			}
		}
		if (start == true) {
			// move title and subtitle up
			title.transform.position = new Vector2(title.transform.position.x, title.transform.position.y + titleDist);
			subtitle.transform.position = new Vector2(subtitle.transform.position.x, subtitle.transform.position.y + subDist);

			// move wasd and arrows sprites up
			wasd.transform.position = new Vector2(wasd.transform.position.x, wasd.transform.position.y + 0.105f);
			arrows.transform.position = new Vector2(arrows.transform.position.x, arrows.transform.position.y + 0.105f);

			// move p1 and p2 sprites up
			p1.transform.position = new Vector2(p1.transform.position.x, p1.transform.position.y + pDist);
			p2.transform.position = new Vector2(p2.transform.position.x, p2.transform.position.y + pDist);

			// shrink title
			title.transform.localScale = new Vector3(title.transform.localScale.x - 0.01f, title.transform.localScale.y - 0.01f, title.transform.localScale.z);

			time -= 1;
		}
		if (time == 0) {
			start = false;

			subtitle.text = "Objective:\nWork with your partner to survive for as long as possible!";

			startText.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		}
	}
}
