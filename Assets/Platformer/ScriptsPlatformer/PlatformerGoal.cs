using UnityEngine;

public class PlatformerGoal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("You WIN!");
            PlatformerSystem.onGameStateChange?.Invoke(true);
        }
    }
}
