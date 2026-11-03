using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformerMovement : MonoBehaviour
{
    [Header("Physics n' Animations")]
    [SerializeField] private Rigidbody2D playerRigidbody;
    [SerializeField] private Animator animator;

    [Header("Movement")]
    [SerializeField] private float jumpForce;
    [SerializeField] private int speed;
    [SerializeField] private float moveInput;
    private bool facingright = true;

    [Header("Ground Check Stuff")]
    [SerializeField] private Vector2 groundCheckSize;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundLayer;

    #region Custom Functions
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            playerRigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            // Debug.Log("Jump" + context.phase);
        }
    }

    private bool IsGrounded()
    {
        // Checks for the overlap with anything from the Ground Layer.
        return Physics2D.BoxCast(transform.position, groundCheckSize, 0, -transform.up, groundCheckDistance, groundLayer);
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>().x;
    }

    private void FlipSprite()
    {
        // if player is facing right and input is left
        // or if player is facing left and input is right
        if (facingright && moveInput < 0f || !facingright && moveInput > 0f)
        {
            facingright = !facingright;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
            Debug.Log("FLIP!");
        } 
    }
    #endregion

    #region Unity Functions
    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        playerRigidbody.linearVelocity = new Vector2(moveInput * speed, playerRigidbody.linearVelocity.y);
        animator.SetFloat("xVelocity", Math.Abs(playerRigidbody.linearVelocityX));
        FlipSprite();
    }

    /* Uncomment this to see the groundCheck box.
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position -transform.up * groundCheckDistance, groundCheckSize);
    }
    */
    #endregion
}
