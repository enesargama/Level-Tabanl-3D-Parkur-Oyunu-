using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private LevelCompleteManager levelCompleteManager;

    private void Start()
    {
        levelCompleteManager = FindObjectOfType<LevelCompleteManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (levelCompleteManager != null)
            {
                levelCompleteManager.ShowLevelCompletePanel();
            }
        }
    }
}
