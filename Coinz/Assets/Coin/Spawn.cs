using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    public GameObject coin;
    public GameObject[] coins;
    public int coinAmount;

    // Use this for initialization
    void Start()
    {
        coins = new GameObject[coinAmount];

        for (int x = 0; x < coinAmount; x++)
        {
            GameObject coinObject = Instantiate(coin, new Vector2(x-(coinAmount/2), 0), Quaternion.identity) as GameObject;
            GameObject textObject = coinObject.transform.GetChild(0).gameObject;
            TextMesh coinText = textObject.GetComponent<TextMesh>();
             
            int number = Random.Range(1, 10);
            if (number == 0)
            {
                coinText.text = "Z";
                coinText.fontSize = 48;
                coinText.color = new Color(0, 0.2F, 0.8F);
            }
            else
            {
                coinText.text = number.ToString();
            }

            coins[x] = coinObject;
        }
    }
      
  
	
}
