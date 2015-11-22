using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
    private float timer;
    public float turnTime;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        float seconds = Mathf.Floor(timer % 60);
        gameObject.GetComponent<TextMesh>().text = (turnTime - seconds).ToString("00");

        if (seconds >= turnTime)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().switchTurn();
            resetTimer();
        }
    }

    public void resetTimer()
    {
        timer = 0;
    }
}
