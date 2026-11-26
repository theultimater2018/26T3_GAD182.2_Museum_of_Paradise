using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

namespace ToxicGetaway
{
    public class ToxicPipes : MonoBehaviour
    {
        public GameObject toxicWasteFall;


        void Start()
        {
            StartCoroutine(LoopFiveSeconds());
        }

        public IEnumerator LoopFiveSeconds()
        {
            while (true)
            {
                toxicWasteFall.SetActive(true);
                yield return new WaitForSeconds(2f);
                toxicWasteFall.SetActive(false);
                yield return new WaitForSeconds(5f);
            }
        }
    }
}

