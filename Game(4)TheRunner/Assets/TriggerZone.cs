using UnityEngine;
using System.Collections;

public class TriggerZone : MonoBehaviour {
	void OnTriggerEnter (Collider other) {
		Destroy (other.gameObject);
	}
}
