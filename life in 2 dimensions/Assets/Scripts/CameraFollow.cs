using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector2 offset;

    private Vector2 desiredPosition;

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position with an offset
            desiredPosition = (Vector2)target.position + offset;

            // Smoothly move the camera towards the desired position
            Vector2 smoothedPosition = Vector2.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
        }
    }
}
