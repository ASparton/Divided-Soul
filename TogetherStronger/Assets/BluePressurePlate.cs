using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePressurePlate : MonoBehaviour
{
    private SpriteRenderer m_spriteRenderer;
    private BoxCollider2D m_box;
    private Sprite BLUE_PLATE_NON_ACTIVATED;
    private Sprite BLUE_PLATE_ACTIVATED;
    private Door m_door;

    // Start is called before the first frame update (used for initialisation)
    void Start()
    {
        this.m_spriteRenderer = this.GetComponent<SpriteRenderer>();
        this.m_spriteRenderer.sprite = this.BLUE_PLATE_NON_ACTIVATED;
        this.m_box = this.GetComponent<BoxCollider2D>();
        this.m_box.isTrigger = true;
    }

    // Change the pressure plate's texture depending on if it is activated or not
    void setActivated(bool activated)
    {
        if (activated)
        {
            this.m_spriteRenderer.sprite = this.BLUE_PLATE_ACTIVATED;
        }
        else
        {
            this.m_spriteRenderer.sprite = this.BLUE_PLATE_NON_ACTIVATED;
        }
    }

    // Activate the pressure plate and open it's linked door if the blue player has entered the body
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerBlue"))
        {
            this.setActivated(true);
            this.m_door.setOpen(true);
        }
    }

    // Deactivate the pressure plate and close it's linked door if the blue player has exited the body
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerBlue"))
        {
            this.setActivated(false);
            this.m_door.setOpen(false);
        }
    }
}
