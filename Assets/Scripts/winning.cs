using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winning : MonoBehaviour {

    public Canvas gameWin;
    public GameObject door;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("win");
        if (collision.gameObject.tag == "Player" && door.GetComponent<dooropen>().opendoor == true)
        {
            gameWin.enabled = true;
            gameWin.GetComponent<winCondition>().won = true;
        }
    }
}
