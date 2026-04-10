using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [Header("Coin Settings")]
    public int coinScore = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealthController healthController = other.GetComponent<HealthController>();

            if (healthController != null)
            {
                healthController.AddScore(coinScore);
            }

            Destroy(gameObject);
        }
    }
}
