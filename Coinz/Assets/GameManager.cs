using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    [HideInInspector]
    public int playerTurn;
    [HideInInspector]
    public int destroyed;

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
            Debug.Log("GAME OVER");
        }
    }


}
