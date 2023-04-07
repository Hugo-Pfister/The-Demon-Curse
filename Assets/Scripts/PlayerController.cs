using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveSpeed = 5f;

    void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);
    }
}

