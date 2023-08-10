using UnityEngine;


public class Movement : MonoBehaviour
{
    public Animator animatior;
    public float speed = 100f;
    public bool grounded; // Check if sprite is touching "ground". this is for jumping
    public float max_horizontal = 200f; //maximum horizontal speed
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb2D;
    public float gravityScale = 10;
    public float fallingGravityScale = 40;
    public float jumpAmount = 100;

    void Start()
    {
        // Get the SpriteRenderer component from the game object
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // When sprite collides with object that has tag "ground" it is available top jump
        if (collision.gameObject.tag == "ground")
        {
            grounded = true;
        }
    }


    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded == true)
            {
                rb2D.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
                grounded = false;
            }
 
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            // pos.x += speed * Time.deltaTime;
                
                
            rb2D.velocity = new Vector3(max_horizontal, rb2D.velocity.y);
                
            
            // Do not flip the sprite (face right)
            spriteRenderer.flipX = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
 
            rb2D.velocity = new Vector3(-max_horizontal, rb2D.velocity.y);
                
            //pos.x -= speed * Time.deltaTime;
            // Flip the sprite to face left
            spriteRenderer.flipX = false;
        }
        if (rb2D.velocity.y >= 0)
        {
            rb2D.gravityScale = gravityScale;
        }
        else if (rb2D.velocity.y < 0)
        {
            rb2D.gravityScale = fallingGravityScale;
        }

        //transform.position = pos;
    }
}