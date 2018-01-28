using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropen : MonoBehaviour {

    public bool opendoor;

    void Start()
    {
        opendoor = false;
    }
    // Update is called once per frame
    void Update () {
		if(opendoor == true)
        {
            transform.position = new Vector3(4f, 9.49f, 0f);
            gameObject.GetComponent<Collider2D>().transform.position = new Vector3(4f, 9.49f, 0f); 
        }
	}
}
