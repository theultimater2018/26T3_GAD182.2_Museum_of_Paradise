using ToxicGetaway;
using UnityEngine;

namespace ToxicGetaway
{
    public class HeartEffects2 : MonoBehaviour
    {

        public HPRestoreDonut hpRestoreDonutScript;
        public GameObject donut;

        public GameObject donutHeartParticleSystemGameObject;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            donutHeartParticleSystemGameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            ParticleEffectTriggered();
        }

        public void ParticleEffectTriggered()
        {
            if (hpRestoreDonutScript.playerIsCollidingWithBurger == true)
            {
                donutHeartParticleSystemGameObject.SetActive(true);
            }
        }


    }
}
