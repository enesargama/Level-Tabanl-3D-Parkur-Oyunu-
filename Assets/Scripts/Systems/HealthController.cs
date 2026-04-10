using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [Header("Health Settings")]
    public int maxHealth = 3;
    public int currentHealth;

    [Header("Score Settings")]
    public int totalScore = 0;

    [Header("UI References")]
    public Text healthText;
    public Text scoreText;

    private RetryManager retryManager;

    private void Start()
    {
        currentHealth = maxHealth;
        retryManager = FindObjectOfType<RetryManager>();
        UpdateUI();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            UpdateUI();

            if (retryManager != null)
            {
                retryManager.ShowRetryPanel();
            }

            gameObject.SetActive(false);
            return;
        }

        UpdateUI();
    }

    public void AddScore(int score)
    {
        totalScore += score;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (healthText != null)
            healthText.text = "Can: " + currentHealth;

        if (scoreText != null)
            scoreText.text = "Puan: " + totalScore;
    }
}
