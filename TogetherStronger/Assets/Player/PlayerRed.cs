using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRed : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;

    public KeyCode up;
    public KeyCode down;
    public KeyCode right;
    public KeyCode left;


    // Start is called before the first frame update -> initialisation of the scene
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame -> play the animation
    private void Update()
    {
        Animator anim = GetComponent<Animator>();
        anim.Play("PlayerRedAnim");
    }

    // Called once per frame and handle physics -> handle movements
    private void FixedUpdate()
    {
        if (Input.GetKey(left))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
            
        else if (Input.GetKey(right))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
            
        else if (Input.GetKey(up))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            rb.velocity = new Vector2(rb.velocity.x, moveSpeed);
        }
            
        else if (Input.GetKey(down))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            rb.velocity = new Vector2(rb.velocity.x, -moveSpeed);
        }

        else
        {
            rb.velocity = new Vector2(rb.velocity.x,0);
            rb.velocity = new Vector2(0,rb.velocity.y);
        }
    }
}