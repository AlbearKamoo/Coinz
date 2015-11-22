using UnityEngine;
using System.Collections;

public class TakeCoin : MonoBehaviour {
    private GameObject scoreObject;
    private GameObject containerObject;
    private GameObject[] container;
    private int scoreValue;

	// Use this for initialization
	void Awake () {
        
	}
	
	// Update is called once per frame
	void Update () {
	   
	}

    void OnMouseDown()
    {
        containerObject = GameObject.Find("GameManager");
        container = containerObject.GetComponent<Spawn>().coins;

        int objectIndex = System.Array.IndexOf(container, gameObject);

        if (objectIndex + 1 < container.Length && objectIndex - 1 >= 0)
        {
            if (container[objectIndex + 1] == null || container[objectIndex - 1] == null)
            {
                takeCoin(containerObject);
            }
        }
        else
        {
            takeCoin(containerObject);
        }
    }

    void takeCoin(GameObject manager)
    {
        int turn = manager.GetComponent<GameManager>().playerTurn;
        GameManager winManager = manager.GetComponent<GameManager>();
        Timer timer = GameObject.Find("Countdown").GetComponent<Timer>();

        if (turn == 1)
        {
            scoreObject = GameObject.Find("Player1Score");
            manager.GetComponent<GameManager>().switchTurn();
        }
        else
        {
            scoreObject = GameObject.Find("Player2Score");
            manager.GetComponent<GameManager>().switchTurn();
        }
        scoreValue = int.Parse(scoreObject.GetComponent<TextMesh>().text);
        scoreValue += int.Parse(gameObject.transform.GetChild(0).GetComponent<TextMesh>().text);
        scoreObject.GetComponent<TextMesh>().text = scoreValue.ToString();

        timer.resetTimer();
        winManager.checkWin();
        Destroy(gameObject);
    }
}
