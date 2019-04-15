using UnityEngine;

public class MotionScript : MonoBehaviour
{
    void Start() {
    }

    void Update() {

        float left_right = Input.GetAxis("Horizontal");
        float up_down = Input.GetAxis("Vertical");

        transform.Translate(left_right, up_down, 0);
    }
}
