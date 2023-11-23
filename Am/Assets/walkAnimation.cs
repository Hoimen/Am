using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Get input for movement (horizontal axis)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Set the IsWalking parameter based on input
        bool isWalking = Mathf.Abs(horizontalInput) > 0.1f;
        animator.SetBool("IsWalking", isWalking);
    }
}