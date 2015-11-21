using UnityEngine;
using System.Collections;

public class TakeCoin : MonoBehaviour {
    public GameObject scoreObject;
    public int scoreValue;

	// Use this for initialization
	void Awake () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	   
	}

    void OnMouseDown()
    {
        scoreObject = GameObject.Find("Player1Score");
        scoreValue = int.Parse(scoreObject.GetComponent<TextMesh>().text);
        scoreValue += int.Parse(gameObject.transform.GetChild(0).GetComponent<TextMesh>().text);
        scoreObject.GetComponent<TextMesh>().text = scoreValue.ToString();
        Destroy(gameObject);
    }
}
