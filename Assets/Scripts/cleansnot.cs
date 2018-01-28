using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleansnot : MonoBehaviour {

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Sneeze")
        {
            Destroy(collision.gameObject);

        }


    }
}
