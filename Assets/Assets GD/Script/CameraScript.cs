using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float smoothSpeed = 0.125f; // Speed at which the camera follows the player
    public Vector3 offset; // Offset of the camera from the player

    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset; // Calculate the desired position of the camera
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Smoothly move the camera towards the desired position
        transform.position = smoothedPosition; // Update the position of the camera
    }
}
