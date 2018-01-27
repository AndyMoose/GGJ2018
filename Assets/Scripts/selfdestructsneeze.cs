using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdestructsneeze : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "npc")
        {
            Destroy(this.gameObject);
        }
    }
}
    

