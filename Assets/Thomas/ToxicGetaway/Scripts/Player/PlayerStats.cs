using UnityEngine;
using UnityEngine.SceneManagement;

namespace ToxicGetaway
{
    public class PlayerStats : MonoBehaviour
    {

        public int HP;
        public int maxHP = 3;

        public TMPro.TextMeshProUGUI healthTextMeshPro;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            HP = maxHP;

            healthTextMeshPro.text = "HP: " + HP.ToString();
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
                SceneManager.LoadScene("Swallowed");
            }
        }
    }
}
