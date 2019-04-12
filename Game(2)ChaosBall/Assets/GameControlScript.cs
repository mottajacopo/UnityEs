using UnityEngine;
using System.Collections;

public class GameControlScript : MonoBehaviour {
	public GameObject blueBall, greenBall, redBall, orangeBall;
	private bool isGameOver = true;	

	void Update () {
		isGameOver = !blueBall && !greenBall && !redBall && !orangeBall;		
	}

	void OnGUI() {
		if(isGameOver) {
			Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
			GUI.Box (rect, "Game Over");

			Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
			GUI.Label (rect2, "Good Job!");
		}
	}
}