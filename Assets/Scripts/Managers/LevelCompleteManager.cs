using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteManager : MonoBehaviour
{
    [Header("UI References")]
    public GameObject levelCompletePanel;

    private void Start()
    {
        if (levelCompletePanel != null)
        {
            levelCompletePanel.SetActive(false);
        }
    }

    public void ShowLevelCompletePanel()
    {
        if (levelCompletePanel != null)
        {
            levelCompletePanel.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void LoadNextLevel()
    {
        Time.timeScale = 1f;

        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        int nextIndex = currentIndex + 1;

        if (nextIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextIndex);
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void ExitToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
