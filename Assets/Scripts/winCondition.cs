using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winCondition : MonoBehaviour {

    AudioSource fanfare;
    public int totalNPCs;
    //private NPCcontroller infectedNPCs;

    private Canvas gameWin;

    public GameObject door;

    public bool won;

    // Use this for initialization
    void Start () {
        gameWin = gameObject.GetComponent<Canvas>();
        fanfare = GetComponent<AudioSource>();
        won = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (totalNPCs == ScoreScript.scoreValue)
        {
            //gameWin.enabled = true;
            door.GetComponent<dooropen>().opendoor = true;

        }
        if(won)
        {
            if (fanfare.isPlaying == false)
            {
                fanfare.Play();
            }
        }
	}
}
