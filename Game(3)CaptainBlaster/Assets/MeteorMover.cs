using UnityEngine;
using System.Collections;

public class MeteorMover : MonoBehaviour {
	public float speed = -2f;
	private Rigidbody2D rigidBody;

	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		rigidBody.velocity = new Vector2 (0, speed);
	}
}
