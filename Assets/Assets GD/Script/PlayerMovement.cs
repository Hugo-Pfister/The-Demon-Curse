using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // The speed at which the player should move

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component of the player GameObject
    }

    private void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal"); // Get the horizontal input axis
        float verticalMovement = Input.GetAxis("Vertical"); // Get the vertical input axis

        Vector2 movement = new Vector2(horizontalMovement, verticalMovement); // Create a movement vector

        rb.velocity = movement * moveSpeed; // Set the velocity of the Rigidbody2D component to the movement vector multiplied by the move speed
    }
}
