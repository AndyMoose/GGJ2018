using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCcontroller : MonoBehaviour {

	private void OnTriggerEnter(Collider2d collider)
    {
        if (collider.tag == "Sneeze")
        {

        }
    }
}
