using UnityEngine;
using UnityEngine.SceneManagement;

namespace ToxicGetaway
{
    public class Ladder : MonoBehaviour
    {

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            SceneManager.LoadScene("Escaped");
        }
    }
}
