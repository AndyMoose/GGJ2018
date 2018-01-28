using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLoseCollision : MonoBehaviour {
    public bool collisionLoss = false;
	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update () {
        if (collisionLoss)
            Debug.Log("collisionLoss now true in update");
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "hazmat")
        {
            collisionLoss = true;
            Debug.Log("collisionLoss is now true");
        }
    }


}
