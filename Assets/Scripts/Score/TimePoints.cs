using UnityEngine;
using System.Collections;

public class TimePoints : MonoBehaviour {

    public GUIText timerText;
    public float levelTimer = 0f;
    bool isCounting = false;
    float time = 0f;
    public int points;
    public bool updateTimer = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isCounting)
        {
            time += Time.deltaTime;
            if(time > 1f)
            {
                points += 1;
                timerText.text = levelTimer.ToString();
            }
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            updateTimer = false;
        }
    }

}
