using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target to follow (character's transform)
    public Vector3 offset; // The offset from the target's position

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("CameraFollow: No target assigned!");
            return;
        }

        // Update the camera's position based on the target's position and the offset
        transform.position = target.position + offset;
    }
}