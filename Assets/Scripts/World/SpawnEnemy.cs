using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject objectToSpawn;
    public Transform spawnPoint;
    public float spawnInterval = 2f;
    public float destroyAfterSeconds = 5f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }

    private void SpawnObject()
    {
        if (objectToSpawn == null || spawnPoint == null) return;

        GameObject spawnedObject = Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
        Destroy(spawnedObject, destroyAfterSeconds);
    }
}
