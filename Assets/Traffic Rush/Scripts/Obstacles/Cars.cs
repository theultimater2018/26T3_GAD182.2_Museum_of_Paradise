using UnityEngine;

/// <summary>
/// Moves an object in one direction for a fixed time, then resets.
/// Attach this script to the GameObject you want to move.
/// </summary>
public class Cars : MonoBehaviour
{
    public Vector3 moveDirection = Vector3.right; // Direction to move
    public float moveSpeed = 5f;                  // Units per second
    public float moveDuration = 2f;               // Time to move before reset

    private Vector3 startPosition;                // Original position
    private float timer;                          // Tracks elapsed time

    public Transform playerLocation;

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

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.position = playerLocation.position;
        }
    }
}

