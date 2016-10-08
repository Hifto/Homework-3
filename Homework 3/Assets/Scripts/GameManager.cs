using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum GameState {
	menu,
	inGame,
	gameOver,
    nextLevel
}

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public GameState currentGameState = GameState.menu;

	public Canvas menuCanvas;
	public Canvas inGameCanvas;
	public Canvas gameOverCanvas;
    public Canvas nextLevelCanvas;

	public int collectedCoins = 0;

	void Awake() {
		instance = this;
	}

	void Start() {
		currentGameState = GameState.menu;
	}
	
	//called to start the game
	public void StartGame() {
		PlayerController.instance.StartGame();
        SetGameState(GameState.inGame);
	}
	
	//called when player die
	public void GameOver() {
		SetGameState(GameState.gameOver);
	}

    //play again from game over screen
    public void PlayAgain()
    {
        SceneManager.LoadScene("MainScene");
    }

	//called when player decides to go back to the menu
	public void BackToMenu() {
		SetGameState(GameState.menu);
        SceneManager.LoadScene("MainScene");
    }

    public void StartSecondLevel()
    {
        SetGameState(GameState.inGame);
        PlayerController.instance.runningSpeed = 3f;
    }

	void SetGameState (GameState newGameState) {
		
		if (newGameState == GameState.menu) {
			//setup Unity scene for menu state
			menuCanvas.enabled = true;
			inGameCanvas.enabled = false;
			gameOverCanvas.enabled = false;
            nextLevelCanvas.enabled = false;
        }
		else if (newGameState == GameState.inGame) {
			//setup Unity scene for inGame state
			menuCanvas.enabled = false;
			inGameCanvas.enabled = true;
			gameOverCanvas.enabled = false;
            nextLevelCanvas.enabled = false;
        }
		else if (newGameState == GameState.gameOver) {
			//setup Unity scene for gameOver state
			menuCanvas.enabled = false;
			inGameCanvas.enabled = false;
			gameOverCanvas.enabled = true;
            nextLevelCanvas.enabled = false;
        }
        else if (newGameState == GameState.nextLevel)
        {
            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = false;
            nextLevelCanvas.enabled = true;
        }

		currentGameState = newGameState;
	}

	void Update() {

		if (Input.GetButtonDown("s")) {
			StartGame();
		}
	}

	public void CollectedCoin() {
		collectedCoins ++;
	}
}



