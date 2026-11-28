using UnityEngine;

public class WaterHazard : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Splish Sploosh");
            PlatformerSystem.OnPlayerKill?.Invoke();
            PlatformerSystem.OnPlayerDamaged?.Invoke(); // Invoke the sounds (Splash & Hurt)
        }
    }
}
