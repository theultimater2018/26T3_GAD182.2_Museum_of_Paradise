using ToxicGetaway;
using UnityEngine;

namespace ToxicGetaway
{
    public class HeartEffects : MonoBehaviour
    {

        public HPRestore hpRestoreBurgerScript;
        public GameObject burger;

        public GameObject burgerHeartParticleSystemGameObject;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            burgerHeartParticleSystemGameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            ParticleEffectTriggered();
        }

        public void ParticleEffectTriggered()
        {
            if (hpRestoreBurgerScript.playerIsCollidingWithBurger == true)
            {
                burgerHeartParticleSystemGameObject.SetActive(true);
            }
        }


    }
}
