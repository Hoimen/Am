using UnityEngine;

public class SpeedPad : MonoBehaviour
{
    public float speedBoostFactor = 2.0f; // Factor by which speed will be boosted

    private void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb2D = other.GetComponent<Rigidbody2D>();

        if (rb2D != null)
        {
            // Apply speed boost to the colliding Rigidbody2D
            rb2D.velocity *= speedBoostFactor;
        }
    }
}