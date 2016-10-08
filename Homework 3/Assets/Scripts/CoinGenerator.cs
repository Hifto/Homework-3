using UnityEngine;
using System.Collections;

public class CoinGenerator : MonoBehaviour {

    public static CoinGenerator instance;
    //coin blueprint
    public CoinPiece coinBlueprint = new CoinPiece();
    //starting coin location
    public Transform coinStartSpot;
    //all coins in the level so far
    public CoinPiece coinPieces = new CoinPiece();

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start ()
    {
        GenerateInitialPieces();	
	}

    public void GenerateInitialPieces()
    {
        for (int i = 0; i < 2; i++)
        {
            AddPiece();
        }
    }

    public void AddPiece()
    {
    }
}

    // Update is called once per frame
    void Update () {
	
	}
}
