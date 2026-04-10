using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerScript : MonoBehaviour
{
    [Header("Movement Settings")]
    public float forwardSpeed = 8f;
    public float horizontalSpeed = 5f;
    public float jumpForce = 7f;

    [Header("Ground Check")]
    public string groundTag = "Zemin";

    private Rigidbody rb;
    private bool isGrounded = true;
    private RetryManager retryManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        retryManager = FindObjectOfType<RetryManager>();
    }

    private void Update()
    {
        MoveForward();
        MoveHorizontal();
        JumpControl();
        FallControl();
    }

    private void MoveForward()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, forwardSpeed);
    }

    private void MoveHorizontal()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * horizontalSpeed * Time.deltaTime);
    }

    private void JumpControl()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void FallControl()
    {
        if (transform.position.y < -5f)
        {
            if (retryManager != null)
            {
                retryManager.ShowRetryPanel();
            }

            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(groundTag))
        {
            isGrounded = true;
        }
    }
}
