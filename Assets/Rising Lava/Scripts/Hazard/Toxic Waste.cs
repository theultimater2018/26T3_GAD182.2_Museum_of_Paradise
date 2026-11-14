using UnityEngine;

public class ToxicWaste : MonoBehaviour
{
    private Vector3 startPosition;
    public float moveSpeed = 0.02f;

    public PlayerStats playerStatsScript;

    public int damage;

    void Start()
    {
        startPosition = transform.position;

        damage = playerStatsScript.maxHP;
    }

    void Update()
    {
            transform.position += Vector3.up * moveSpeed; 
    }

    public void DamagePlayer()
    {
        playerStatsScript.HP -= damage;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DamagePlayer();
        }

    }
}

