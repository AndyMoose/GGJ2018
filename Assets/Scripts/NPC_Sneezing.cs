using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Sneezing : MonoBehaviour {

    public int numberOfSneezes;
    private int sneezesUsed;

    private int timeBetweenSneezes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.Sneeze();
    }

    public void Sneeze()
    {
        timeBetweenSneezes = Random.Range(3, 10);
        //if(NPCcontroller.)
    }
}
