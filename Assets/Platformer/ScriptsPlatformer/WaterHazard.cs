using UnityEngine;

public class WaterHazard : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Kill Player
            Debug.Log("Splish Sploosh");
        }
    }
}
