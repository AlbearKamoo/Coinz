using UnityEngine;
using System.Collections;

public class LabelManager : MonoBehaviour {
    protected GameObject player1Label;
    protected GameObject player2Label;
    protected GameObject manager;

	// Use this for initialization
	void Awake () {
        player1Label = GameObject.Find("Player1Label");
        player2Label = GameObject.Find("Player2Label");
        player1Label.GetComponent<TextMesh>().fontStyle = FontStyle.Bold;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changeLabel()
    {
        player1Label = GameObject.Find("Player1Label");
        player2Label = GameObject.Find("Player2Label");
        manager = GameObject.Find("GameManager");

        if (manager.GetComponent<GameManager>().playerTurn == 1)
        {
            player1Label.GetComponent<TextMesh>().fontStyle = FontStyle.Bold;
            player2Label.GetComponent<TextMesh>().fontStyle = FontStyle.Normal;
        }
        else
        {
            player1Label.GetComponent<TextMesh>().fontStyle = FontStyle.Normal;
            player2Label.GetComponent<TextMesh>().fontStyle = FontStyle.Bold;
        }
    }
}
