using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPressurePlate : MonoBehaviour
{
    public SpriteRenderer m_spriteRenderer;
    public Sprite RED_PLATE_NON_ACTIVATED;
    public Sprite RED_PLATE_ACTIVATED;
    public Door m_door;

    // Start is called before the first frame update
    void Start()
    {
        this.m_spriteRenderer = this.GetComponent<SpriteRenderer>();
        this.m_spriteRenderer.sprite = RED_PLATE_NON_ACTIVATED; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setActivated(bool activated)
    {
        if (activated)
        {
            m_spriteRenderer.sprite = RED_PLATE_ACTIVATED;
        }
        else
        {
            m_spriteRenderer.sprite = RED_PLATE_NON_ACTIVATED;
        }
    }

    private void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.CompareTag("PlayerRed"))
        {
            setActivated(true);
            m_door.setOpen(true);
        }
    }

    private void OnTriggerExit2D(Collider2D body)
    {
        if (body.gameObject.CompareTag("PlayerRed"))
        {
            setActivated(false);
            m_door.setOpen(false);
        }
    }
}
