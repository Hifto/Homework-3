using UnityEngine;
using System.Collections;

public class LeaveTrigger : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other) {

		LevelGenerator.instance.AddPiece();
		LevelGenerator.instance.RemoveOldestPiece();
        LevelGenerator.instance.NextLevel();
        CoinGenerator.instance.AddPiece();

        //Speed up game
        if (PlayerController.instance.runningSpeed <= 5)
        {
            PlayerController.instance.runningSpeed += 1;
        }
        else if (PlayerController.instance.runningSpeed <= 10)
        {
            PlayerController.instance.runningSpeed += .2f;
        }
        else
        {
            PlayerController.instance.runningSpeed += .1f;
        }
            
	}
	
}
