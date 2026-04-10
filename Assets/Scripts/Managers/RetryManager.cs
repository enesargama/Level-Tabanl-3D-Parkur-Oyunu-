using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryManager : MonoBehaviour
{
    [Header("UI References")]
    public GameObject retryPanel;

    private void Start()
    {
        if (retryPanel != null)
        {
            retryPanel.SetActive(false);
        }
    }

    public void ShowRetryPanel()
    {
        if (retryPanel != null)
        {
            retryPanel.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void RetryLevel()
    {
        Time.timeScale = 1f;
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
