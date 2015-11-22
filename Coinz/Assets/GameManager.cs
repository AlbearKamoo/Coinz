using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    [HideInInspector]
    public int playerTurn;
    [HideInInspector]
    public int destroyed;
    [HideInInspector]
    public string winner;
    public LabelManager labelManager;
    

    // Use this for initialization
    void Start () {
        playerTurn = 1;
        destroyed = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void switchTurn()
    {
        if (playerTurn == 1)
        {
            playerTurn = 2;
        }
        else
        {
            playerTurn = 1;
        }
        labelManager.changeLabel();
    }

    public void checkWin()
    {
        destroyed += 1;
        if (destroyed == gameObject.GetComponent<Spawn>().coinAmount)
        {
            int player1score = int.Parse(GameObject.Find("Player1Score").GetComponent<TextMesh>().text);
            int player2score = int.Parse(GameObject.Find("Player2Score").GetComponent<TextMesh>().text);
            if (player1score > player2score)
            {
                winner = "Player 1 wins!";
            }
            else if(player2score > player1score)
            {
                winner = "Player 2 wins!";
            }
            else
            {
                winner = "It's a tie!";
            }
            GameObject.Find("Countdown").GetComponent<Timer>().endTimer();
        }   
    }


}
