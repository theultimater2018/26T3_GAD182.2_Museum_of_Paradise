using UnityEngine;

namespace ToxicGetaway
{
    public class PlayerMats : MonoBehaviour
    {

        public PlayerStats playerStatsScript;

        public Material playerMaterial;
        public Material playerHurt;
        public SpriteRenderer playerMeshRenderer;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void UpdateMats() // Updates the players matetial to a darker tone for every 5 HP lost
        {
            if (playerStatsScript.HP <= 2)
            {
                playerMeshRenderer.material = playerHurt;
            }
        }

        public void ResetMats() // Resets the players material to the original material
        {
            playerMeshRenderer.material = playerMaterial;
        }
    }

}
