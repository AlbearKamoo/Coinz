using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public int playerTurn;
    public int destroyed;

    // Use this for initialization
    void Start () {
        playerTurn = 1;
        destroyed = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
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
