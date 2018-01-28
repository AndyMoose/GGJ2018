using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneezedetect : MonoBehaviour {

    private bool chase;
    private Collider2D fuck;
    private char select;
    public bool sneezing;


    private void Start()
    {
        chase = false;
        sneezing = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            fuck = collision;
            chase = true;
            select = 'b';

        }
        else if (collision.tag == "Sneeze")
        {
            if(collision.gameObject.GetComponent<cleanable>().clean)
            {
                fuck = collision;
                chase = true;
                select = 'a';

            }
            
        }
        


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Sneeze")
            chase = false;
    }
        private void Update()
    {
        if(!sneezing){
            if (chase)
            {
                GetComponentInParent<hazmatMaster>().chasing = true;
                GetComponentInParent<Rigidbody2D>().position = Vector2.MoveTowards(GetComponentInParent<Rigidbody2D>().transform.position, fuck.gameObject.GetComponent<Rigidbody2D>().transform.position, .13f);
                //chase = false;


            }
            else
            {
                chase = false;
                GetComponentInParent<hazmatMaster>().chasing = false;
            }
        }
       
    }

}
