using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public MovementJoystick movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMovement = movementJoystick.joystickVec.x;

        // Set vertical movement to zero to restrict it to left and right
        float verticalMovement = 0;

        if (horizontalMovement != 0)
        {
            rb.velocity = new Vector2(horizontalMovement * playerSpeed, verticalMovement);

            // Set the "IsWalking" parameter to control the walking animation
            animator.SetBool("IsWalking", true);

            // Set the "running" parameter to control the running animation
            animator.SetBool("running", true);

            // Flip the character sprite if moving to the right
            if (horizontalMovement > 0)
            {
                spriteRenderer.flipX = true;
            }
            else if (horizontalMovement < 0)
            {
                spriteRenderer.flipX = false;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;

            // Set the "IsWalking" parameter to control the walking animation
            animator.SetBool("IsWalking", false);

            // Set the "running" parameter to control the running animation
            animator.SetBool("running", false);

            // Additional check for idle state before allowing sprite flipping
            if (!animator.GetBool("IsWalking"))
            {
                // Set the "FlipIdle" parameter to control flipping in the idle state
                spriteRenderer.flipX = false; // or set to true, depending on your character's default direction
            }
        }
    }
}
