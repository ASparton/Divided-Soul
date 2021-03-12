using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPressurePlate : MonoBehaviour
{
    private SpriteRenderer m_spriteRenderer;
    public Sprite RED_PLATE_NON_ACTIVATED;
    public Sprite RED_PLATE_ACTIVATED;
    public Door m_door;

    // Start is called before the first frame update (initialisation of the scene)
    private void Start()
    {
        this.m_spriteRenderer = this.GetComponent<SpriteRenderer>();
        this.m_spriteRenderer.sprite = RED_PLATE_NON_ACTIVATED; 
    }

    // Change the sprite
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

    // If the player's color corresponds to the actual pressure's plate color (blue) then open its linked door
    private void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.CompareTag("PlayerRed"))
        {
            setActivated(true);
            m_door.setOpen(true);
        }
    }

    // If the player's color corresponds to the actual pressure's plate color (blue) then closes its linked door
    private void OnTriggerExit2D(Collider2D body)
    {
        if (body.gameObject.CompareTag("PlayerRed"))
        {
            setActivated(false);
            m_door.setOpen(false);
        }
    }
}
