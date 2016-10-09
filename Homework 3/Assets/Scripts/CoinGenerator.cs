using UnityEngine;
using System.Collections;

public class CoinGenerator : MonoBehaviour {

    public static CoinGenerator instance;

    void Awake()
    {
        instance = this;
    }

    public void AddPiece()
    {
        var coin = GameObject.Find("Coin");

        for (int count = 0; count <= 6; count++)
        {
            int randomX = Random.Range((int)PlayerController.instance.transform.position.x + 3, (int)PlayerController.instance.transform.position.x + 20);
            int randomY = Random.Range((int)PlayerController.instance.transform.position.y, (int)PlayerController.instance.transform.position.y + 5);
            var pos = new Vector3(randomX, randomY, 0);
            Instantiate(coin, pos, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
