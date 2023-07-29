using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the SpriteRenderer component from the game object
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
            // Do not flip the sprite (face right)
            spriteRenderer.flipX = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
            // Flip the sprite to face left
            spriteRenderer.flipX = false;
        }

        transform.position = pos;
    }
}