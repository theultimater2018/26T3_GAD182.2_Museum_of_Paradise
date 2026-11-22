using UnityEngine;

namespace ToxicGetaway
{
    public class Bee : MonoBehaviour
    {
        public Vector3 moveDirection = Vector3.right; // Direction to move
        public float moveSpeed = 5f;                  // Units per second
        public float moveDuration = 2f;               // Time to move before reset

        private Vector3 startPosition;                // Original position
        private float timer;                          // Tracks elapsed time

        void Start()
        {
            // Store the starting position
            startPosition = transform.position;
            timer = 0f;
        }

        void Update()
        {
            // Update timer
            timer += Time.deltaTime;

            if (timer <= moveDuration)
            {
                // Move object in the specified direction
                transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
            }
            else
            {
                // Reset position and timer
                transform.position = startPosition;
                timer = 0f;
            }
        }
    }
}