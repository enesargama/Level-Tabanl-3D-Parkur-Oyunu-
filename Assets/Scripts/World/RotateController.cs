using UnityEngine;

public class RotateController : MonoBehaviour
{
    [Header("Rotation Settings")]
    public Vector3 rotationAmount = new Vector3(0f, 100f, 0f);

    private void Update()
    {
        transform.Rotate(rotationAmount * Time.deltaTime);
    }
}
