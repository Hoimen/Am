using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            // puts vertical force on the player guy
            Vector2 jumpDirection = Vector2.up * jumpForce;
            rb.AddForce(jumpDirection, ForceMode2D.Impulse);
        }
    }
}
