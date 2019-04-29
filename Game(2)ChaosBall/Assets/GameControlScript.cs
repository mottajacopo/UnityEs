using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour {
	public GameObject blueBall, greenBall, redBall, orangeBall;
	private bool isGameOver = true;
    private bool restart = false;
    public GameObject player;
    private float elapsedTime = 0;

    void Update () {

        isGameOver = !blueBall && !greenBall && !redBall && !orangeBall;
        if (!isGameOver)
        {
            elapsedTime += Time.deltaTime;
        }
        
        if (restart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            elapsedTime = 0;
        }
	}


    void OnGUI() {
		if(isGameOver) {

            Rect rect = new Rect (Screen.width / 2 -75, Screen.height / 2, 150, 40);
			GUI.Box (rect, "Game Over  Good Job!");

            GUI.Box(new Rect(Screen.width / 2-75 , Screen.height / 2 + 50, 150, 30), "Your Time Was " + ((int)elapsedTime).ToString());

            string message = "Click to Play Again";

            Rect startButton = new Rect(Screen.width / 2-75 , Screen.height / 2 + 90, 150, 30);
            if (GUI.Button(startButton, message))
            {
                restart = true;
            }
        }
	}
}