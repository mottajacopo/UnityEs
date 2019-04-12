using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	public float startSpeed = -0.4f;
	public float timeExtension = 1.5f;
	public Ground ground;

	private float timeRemaining = 10;
	private float totalTimeElapsed = 0;
	private bool isGameOver = false;

	void Update () {
		if (isGameOver) {return;}
		totalTimeElapsed += Time.deltaTime;
		timeRemaining -= Time.deltaTime;
		if (timeRemaining <= 0) {
			isGameOver = true;
		}
	}
	
	public void SlowWorldDown () {
		CancelInvoke("SpeedWorldUp"); // Cancel any commands to speed world up
		ground.SlowDown ();
		Invoke ("SpeedWorldUp", 1); // Speed the world up again after 1 second
		Time.timeScale = 0.5f;
	}
	
	void SpeedWorldUp() {
		Time.timeScale = 1f;
		ground.SpeedUp();
	}
	
	public void PowerupCollected() {
		timeRemaining += timeExtension;
	}
	
	void OnGUI() {
		if(!isGameOver) {
			Rect boxRect = new Rect(Screen.width / 2 - 50, Screen.height - 100, 100, 50);
			GUI.Box (boxRect, "Time Remaining");

			Rect labelRect = new Rect(Screen.width / 2 - 10, Screen.height - 80, 20, 40);
			GUI.Label (labelRect,((int)timeRemaining).ToString());
		} else {
			Rect boxRect = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 100, 120, 50);
			GUI.Box	(boxRect, "Game Over");

			Rect labelRect = new Rect(Screen.width / 2 - 55, Screen.height / 2 - 80, 90, 40);
			GUI.Label (labelRect, "Total Time: " + (int)totalTimeElapsed);

			Time.timeScale = 0;
		}
	}
}
