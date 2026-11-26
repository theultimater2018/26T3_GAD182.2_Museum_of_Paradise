using UnityEngine;

namespace ToxicGetaway
{
    public class HPRestoreBurger : MonoBehaviour
    {

        public PlayerStats playerStatsScript;
        public GameObject burger;

        public int restoreAmount = 1;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void RestoreHealth()
        {
            playerStatsScript.HP += restoreAmount;
            playerStatsScript.healthTextMeshPro.text = "HP: " + playerStatsScript.HP.ToString();
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                RestoreHealth();
                Destroy(burger);

            }

        }
    }
}
