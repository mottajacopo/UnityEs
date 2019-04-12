using UnityEngine;
using System.Collections;

public class VelocityScript : MonoBehaviour {
	public float startSpeed = 50;

	void Start () {
		Rigidbody rigidBody = GetComponent<Rigidbody> ();
		rigidBody.velocity = new Vector3(startSpeed, 0, startSpeed);
	}
}
