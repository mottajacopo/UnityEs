using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {

	void OnTriggerEnter (Collider collider) {
		GameObject collidedWith = collider.gameObject;
		if (collidedWith.tag == gameObject.tag) {
			GetComponent<Light>().intensity = 0;
			Destroy(collidedWith);
		}
	}
}