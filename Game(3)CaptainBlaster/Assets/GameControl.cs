using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControl : MonoBehaviour {
	
	public Text scoreText, gameOverText;
	int playerScore = 0;
	
	public void AddScore () {
		playerScore++;
		scoreText.text = playerScore.ToString();
	}
	
	public void PlayerDied () {
		gameOverText.gameObject.setActive(true);
		Time.timeScale = 0;
	}
}
