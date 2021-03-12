using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlue : MonoBehaviour
{
    public FadeTransition sceneManager;
    public string nextSceneName;
    public float moveSpeed;
    Rigidbody2D rb;
    private bool keepUpdating;

    public KeyCode up;
    public KeyCode down;
    public KeyCode right;
    public KeyCode left;


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        this.keepUpdating = true;
    }

    // Update is called once per frame -> play animations
    private void Update()
    {
        if (keepUpdating)
        {
            Animator anim = GetComponent<Animator>();
            anim.Play("PlayerBlueAnim");
        }
        else
        {
            Animator anim = GetComponent<Animator>();
            anim.Play("FusionAnim");
        }
    }

    // Called once per frame and handle physics -> used for moving the player
    private void FixedUpdate()
    {
        if (keepUpdating)
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
                rb.velocity = new Vector2(rb.velocity.x, 0);
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
        }
    }

    // Handle collision with the other player
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PlayerRed"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.velocity = new Vector2(0, rb.velocity.y);
            this.keepUpdating = false;

            this.transform.position = other.transform.position;
            other.gameObject.SetActive(false);

            SpriteRenderer spriteRenderer = this.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/Player/Fusion");
            transform.localScale *= 2;

            sceneManager.changeScene(nextSceneName);
        }
    }
}