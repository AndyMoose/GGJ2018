using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneezedetect : MonoBehaviour {

    private bool chase;
    private Collider2D fuck;
    private char select;

    private void Start()
    {
        chase = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == "Sneeze")
        {
            if(collision.gameObject.GetComponent<cleanable>().clean)
            {
                fuck = collision;
                chase = true;
                select = 'a';
            }
            
        }
        else if (collision.tag == "Player")
        {
                fuck = collision;
                chase = true;
                select = 'b';          

        }


    }
    private void Update()
    {
        if (chase && fuck != null)
        {
            GetComponentInParent<hazmatMaster>().chasing = true;
            GetComponentInParent<Rigidbody2D>().position = Vector2.MoveTowards(GetComponentInParent<Rigidbody2D>().transform.position, fuck.gameObject.GetComponent<Rigidbody2D>().transform.position, .05f);
            chase = false;
        }
        else
        {
            chase = false;
            GetComponentInParent<hazmatMaster>().chasing = false;
        }
       
    }

}
