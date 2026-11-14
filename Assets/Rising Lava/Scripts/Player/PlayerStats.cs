using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public int HP;
    public int maxHP = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        Dead();
    }

    public void Dead()
    {
        if (HP <= 0)
        {
            Debug.Log("Player has died.");
           // Die();
        }
    }
}
