using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCcontroller : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;

    private SpriteRenderer spriteRenderer;
    void Start()
    {
        
          spriteRenderer = GetComponent<SpriteRenderer>();
          spriteRenderer.sprite = sprite1;

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Sneeze")
        {
            if (spriteRenderer.sprite == sprite1) 
            {
                spriteRenderer.sprite = sprite2;
            }
        }
    }
}
