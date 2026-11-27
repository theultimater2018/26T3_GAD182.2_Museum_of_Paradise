using System.Collections;
using UnityEngine;

public class Spawing : MonoBehaviour
{
    [Header("Spawner Settings")]
    [SerializeField] private GameObject prefabToSpawn; // Drag your prefab here in the Inspector
    [SerializeField] private float spawnInterval = 7f;  // Time between spawns (in seconds)

    private bool isSpawning = true;

    void Start()
    {
        // Start the timed loop
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        // Cache the wait time to avoid repeated allocations in memory
        WaitForSeconds wait = new WaitForSeconds(spawnInterval);

        while (isSpawning)
        {
            yield return wait; // Wait for the specified interval
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        if (prefabToSpawn != null)
        {
            // Spawns the prefab at the spawner's current position and rotation
            Instantiate(prefabToSpawn, transform.position, transform.rotation);
        }
    }

    // Optional: Call this to stop the spawner externally
    public void StopSpawning()
    {
        isSpawning = false;
    }
}
