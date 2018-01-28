using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulecol : MonoBehaviour {

    private SpriteRenderer sr;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Sneeze")
        {
            sr = GetComponentInParent<SpriteRenderer>();
            
            if (sr.sprite == GetComponentInParent<hazmatMaster>().sprite1)
            {
                sr.sprite = GetComponentInParent<hazmatMaster>().sprite2;
                // isWalking = false; // Does not freeze hazmat
            }

        }
    }
}
