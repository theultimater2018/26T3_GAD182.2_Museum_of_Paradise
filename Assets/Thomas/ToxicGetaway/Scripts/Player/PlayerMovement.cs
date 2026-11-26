using UnityEngine;

namespace ToxicGetaway
{
    public class PlayerMovement : MonoBehaviour
    {
        public float moveSpeed = 5f;
        public float jumpForce = 10f;
        public bool isFcacingRight = true;
        public bool isGrounded;
        private Rigidbody2D rb;
        public SpriteRenderer spriteRenderer;

        Animator playerAnimator;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            playerAnimator = GetComponent<Animator>();
        }

        void Update()
        {
            // Horizontal movement
            float moveInput = Input.GetAxis("Horizontal");
            rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

            // Jump
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
                playerAnimator.SetBool("IsJumping", !isGrounded);
            }

            FlipSprite();
        }

        private void FixedUpdate()
        {
            // Update animator parameters
            playerAnimator.SetFloat("xVelocity", Mathf.Abs(rb.linearVelocity.x));
            playerAnimator.SetFloat("yVelocity", rb.linearVelocity.x);
        }

        public void FlipSprite()
        {
            if (rb.linearVelocity.x > 0 && !isFcacingRight || rb.linearVelocity.x < 0 && isFcacingRight)
            {
                isFcacingRight = !isFcacingRight;
                spriteRenderer.flipX = !spriteRenderer.flipX;
            }
        }

  

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
                playerAnimator.SetBool("IsJumping", !isGrounded);
            }
        }

        void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = false;
                playerAnimator.SetBool("IsJumping", !isGrounded);
            }
        }
    }
}

