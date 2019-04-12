using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public GameControl control;
	private Animator anim;

	public float strafeSpeed = 4f;
	private bool jumping = false;
	
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	void Update () {
		float xMovement = Input.GetAxis ("Horizontal") * strafeSpeed * Time.deltaTime;
		if (transform.position.x + xMovement > 3f) xMovement = 3f - transform.position.x;
		if (transform.position.x + xMovement < -3f) xMovement = -3f - transform.position.x; 
		transform.Translate (xMovement, 0f, 0f);

		if (Input.GetButtonDown ("Jump")) {
			anim.SetTrigger ("Jump");
		}

		if (anim.GetCurrentAnimatorStateInfo(0).IsName ("Run")) {
			jumping = false;
		} else {
			jumping = true;
		}
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.name == "PowerUp(Clone)") {
			control.PowerupCollected ();
		} else if(other.gameObject.name == "Obstacle(Clone)" && ! jumping) {
			control.SlowWorldDown ();
		}
		
		Destroy (other.gameObject);
	}
}
