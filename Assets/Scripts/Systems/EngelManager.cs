using UnityEngine;

public class EngelManager : MonoBehaviour
{
    [Header("Damage Settings")]
    public int damageAmount = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HealthController healthController = collision.gameObject.GetComponent<HealthController>();

            if (healthController != null)
            {
                healthController.TakeDamage(damageAmount);
            }
        }
    }
}
