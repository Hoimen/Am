using System;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CustomGravityScript : MonoBehaviour
{
    public float customGravityScale = 100.0f; // Adjust this value to increase gravity

    private Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Apply custom gravity force
        Vector2 customGravity = Vector2.down * Physics2D.gravity.magnitude * customGravityScale;
        rb2D.AddForce(customGravity);
    }
}


