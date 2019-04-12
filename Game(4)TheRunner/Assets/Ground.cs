using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	public float speed = .5f;
	private Renderer groundRenderer;

	void Start () {
		groundRenderer = GetComponent<Renderer>();
	}

	void Update () {
		float offset = Time.time * speed % 1;  // The % 1 keeps offset between 0 and 1
		groundRenderer.material.mainTextureOffset = new Vector2(0, -offset);
	}
	
	public void SlowDown() {
		speed = speed / 2;
	}
	
	public void SpeedUp() {
		speed = speed * 2;
	}
}