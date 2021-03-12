using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayButton : MonoBehaviour
{
    public FadeTransition sceneManager;
    private SpriteRenderer spriteRenderer;
    public Sprite unselectedSprite;
    public Sprite overSprite;

    // Start is called before the first frame update
    private void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Change the sprite to the over sprite and change scene if pressed
    private void OnMouseOver()
    {
        this.spriteRenderer.sprite = overSprite;

        if (Input.GetMouseButton(0))
        {
            sceneManager.changeScene("SampleScene");
        }
    }

    // Change the sprite to the unselected (not hover) sprite
    private void OnMouseExit()
    {
        this.spriteRenderer.sprite = unselectedSprite;
    }
}
