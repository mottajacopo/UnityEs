using UnityEngine;
using System.Collections;

public class ScrollBackground : MonoBehaviour {

	public float speed = -2f;
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0f, speed * Time.deltaTime, 0f);
		
		if(transform.position.y <= -20) {
			transform.Translate(0f, 40f, 0f);
		}
	}
}
