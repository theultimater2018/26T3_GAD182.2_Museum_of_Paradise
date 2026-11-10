using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    public Rigidbody2D playerRB2D;

    private Vector2 moveInput;

    private Animator playerAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        playerRB2D.linearVelocity = moveInput * speed;
    }

    public void MovePlayer(InputAction.CallbackContext context)
    {
        playerAnimator.SetBool("isWalking", true);

        if (context.canceled)
        {
            playerAnimator.SetBool("isWalking", false);
            playerAnimator.SetFloat("LastInputX", moveInput.x);
            playerAnimator.SetFloat("LastInputY", moveInput.y);
        }
        moveInput = context.ReadValue<Vector2>();

        playerAnimator.SetFloat("InputX", moveInput.x);
        playerAnimator.SetFloat("InputY", moveInput.y);
    }
}
