using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target to follow (e.g., player)
    public float smoothTime = 0.05f; // The smoothness of the camera movement (lower value for faster movement)
    public Vector3 offset = new Vector3(100999990f, 100099999999f, -10999999999f); // Offset from the target position
    private Vector3 velocity = Vector3.zero; // Internal velocity variable

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
            transform.position = smoothedPosition;
        }
    }
}