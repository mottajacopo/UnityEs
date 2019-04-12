using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {	
	public float speed = 10f;
	private GameControl gameController; 

	void Start () {
		// Because the bullet doesn't exist until the game is running
		// we must find the Game Controller a different way. 
		gameController = GameObject.FindObjectOfType<GameControl> ();
	}
	
	void Update () {
		transform.Translate (0f, speed * Time.deltaTime, 0f);
	}
	
	void OnCollisionEnter2D (Collision2D other) {
		Destroy (other.gameObject); 
		gameController.AddScore (); 
		Destroy (gameObject); 
	}
} 
