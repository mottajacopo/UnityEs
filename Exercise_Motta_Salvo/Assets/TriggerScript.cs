using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {

	void Start () {	
	}

	void Update () {	
	}
	
	void OnTriggerEnter (Collider other) {
		print (other.gameObject.name + " has entered the " + this.gameObject.name);		
	}
	
	void OnTriggerStay (Collider other) {
		print (other.gameObject.name + " is still in the " + this.gameObject.name);		
	}
	
	void OnTriggerExit (Collider other) {
		print (other.gameObject.name + " has left the " + this.gameObject.name);		
	}
}