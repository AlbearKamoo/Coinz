using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    public GameObject coin;
    public int coinAmount;

    // Use this for initialization
    void Start()
    {
        for (int x = 0; x < coinAmount; x++)
        {
            GameObject coinObject = Instantiate(coin, new Vector2(x-(coinAmount/2), 0), Quaternion.identity) as GameObject;
            GameObject valueText = coinObject.transform.GetChild(0).gameObject;
            int number = Random.Range(1, 10);
            valueText.GetComponent<TextMesh>().text = number.ToString();
        }
    }
      
  
	
}
