using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 100f;
    public bool grounded;
    public int counter = 0;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb2D;

    void Start()
    {
        // Get the SpriteRenderer component from the game object
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            grounded = true;
        }
    }

    //void OnCollisionExit2D(Collision2D collision)
    //{
    // if (collision.gameObject.tag == "ground")
    //{
    //grounded = false;
    // }
    // }

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow) && grounded == true)
        {
            //pos.y += speed * Time.deltaTime;

            grounded = false;
            counter = 0;
        }
        if (grounded == false)
        {
            if (counter < 500)
            {
                rb2D.AddForce(Vector2.up * 1, ForceMode2D.Impulse);
                counter += 1;
            }
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