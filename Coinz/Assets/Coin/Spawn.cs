using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    public GameObject coin;

    // Use this for initialization
    void Start()
    {
        for (int x = 0; x < 5; x++)
        {
            GameObject coinObject = Instantiate(coin, new Vector2(x-2, 0), Quaternion.identity) as GameObject;
            GameObject valueText = coinObject.transform.GetChild(0).gameObject;
            int number = Random.Range(1, 10);
            valueText.GetComponent<TextMesh>().text = number.ToString();
        }
    }
      
  
	
}
