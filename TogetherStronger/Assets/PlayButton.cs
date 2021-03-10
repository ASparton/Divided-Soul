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
    public Sprite clickedSprite;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnMouseOver()
    {
        this.spriteRenderer.sprite = overSprite;

        if (Input.GetMouseButton(0))
        {
            sceneManager.changeScene("SampleScene");
        }
    }

    void OnMouseExit()
    {
        this.spriteRenderer.sprite = unselectedSprite;
    }
}
