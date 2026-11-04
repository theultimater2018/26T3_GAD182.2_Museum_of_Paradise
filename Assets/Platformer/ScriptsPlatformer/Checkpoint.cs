using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Vector2 checkpointLocation;

    private void Awake()
    {
        checkpointLocation = transform.position;
        // Debug.Log("Position :" + checkpointLocation.x + ", " + checkpointLocation.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlatformerSystem.onCheckpointPass?.Invoke(checkpointLocation);
        }
    }
}
