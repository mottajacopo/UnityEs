using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	private GameControl control; 

	void Start () {
		control = GameObject.FindObjectOfType<GameControl> ();
	}

	void Update () {
		transform.Translate (0, 0, control.startSpeed);
	}
}
