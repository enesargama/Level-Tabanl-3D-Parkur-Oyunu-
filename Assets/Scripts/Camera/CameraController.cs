using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Target")]
    public Transform target;

    [Header("Offset Settings")]
    public Vector3 offset = new Vector3(0f, 5f, -7f);

    [Header("Follow Settings")]
    public float smoothSpeed = 5f;

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        transform.position = smoothedPosition;
    }
}
