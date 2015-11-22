﻿using UnityEngine;
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
        Debug.Log(objectIndex);

        if (objectIndex + 1 < container.Length && objectIndex - 1 >= 0)
        {
            if (container[objectIndex + 1] == null || container[objectIndex - 1] == null)
            {
                takeCoin();
            }
        }
        else
        {
            takeCoin();
        }
    }

    void takeCoin()
    {
        scoreObject = GameObject.Find("Player1Score");
        scoreValue = int.Parse(scoreObject.GetComponent<TextMesh>().text);
        scoreValue += int.Parse(gameObject.transform.GetChild(0).GetComponent<TextMesh>().text);
        scoreObject.GetComponent<TextMesh>().text = scoreValue.ToString();
        Destroy(gameObject);
    }
}
