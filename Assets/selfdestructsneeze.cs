using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdestructsneeze : MonoBehaviour {

    private float timer;
    public float stayLength;
	
	// Update is called once per frame
	void Update () {
        timer += 1.0F * Time.deltaTime;
        if (timer >= stayLength)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
