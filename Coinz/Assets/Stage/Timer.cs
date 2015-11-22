using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
    public float timer;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        float seconds = Mathf.Floor(timer % 60);
        gameObject.GetComponent<TextMesh>().text = (10 - seconds).ToString("00");
    }

    public void resetTimer()
    {
        timer = 0;
    }
}
