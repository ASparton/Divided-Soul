using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private SpriteRenderer m_spriteRenderer;
    private BoxCollider2D m_collider;
    public Sprite DOOR_CLOSED;
    public Sprite DOOR_OPENED;

    // Start is called before the first frame update (initialisation of the class)
    private void Start()
    {
        this.m_spriteRenderer = this.GetComponent<SpriteRenderer>();
        this.m_collider = this.GetComponent<BoxCollider2D>();
        setOpen(false);
    }

    // Change the texture and the enable or disable the collisions
    public void setOpen(bool open)
    {
        if (open)
        {
            this.m_spriteRenderer.sprite = DOOR_OPENED;
            this.m_collider.enabled = false;
        }
        else
        {
            this.m_spriteRenderer.sprite = DOOR_CLOSED;
            this.m_collider.enabled = true;
        }
    }
}
