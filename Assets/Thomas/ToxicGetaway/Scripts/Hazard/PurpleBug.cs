using UnityEngine;

namespace ToxicGetaway
{
    public class PurpleBug : MonoBehaviour
    {
        public PlayerStats playerStatsScript;
        public PlayerMats playerMatsScript;

        public int damage = 1;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void DamagePlayer()
        {
            playerStatsScript.HP -= damage;
            playerStatsScript.healthTextMeshPro.text = "HP: " + playerStatsScript.HP.ToString();
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                DamagePlayer();
                playerMatsScript.UpdateMats();

            }

        }

        public void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                playerMatsScript.ResetMats();
            }
        }
    }
}
