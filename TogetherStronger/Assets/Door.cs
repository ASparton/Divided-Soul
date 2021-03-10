using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public SpriteRenderer m_spriteRenderer;
    public BoxCollider2D m_collider;
    public Sprite DOOR_CLOSED;
    public Sprite DOOR_OPENED;

    // Start is called before the first frame update
    void Start()
    {
        this.m_spriteRenderer = this.GetComponent<SpriteRenderer>();
        this.m_collider = this.GetComponent<BoxCollider2D>();
        setOpen(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

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
