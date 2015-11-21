using UnityEngine;
using System.Collections;

public class Setup : MonoBehaviour {

    public Transform[] coins;

	// Use this for initialization
	void Awake () {
        int size = 5;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
public class CoinComponent
{
    public int value;
    public CoinComponent() { }
    public CoinComponent(int value)
    {
        this.value = value;
    }
}
