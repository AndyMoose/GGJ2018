using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winCondition : MonoBehaviour {

    public int totalNPCs;
    //private NPCcontroller infectedNPCs;

    private Canvas gameWin;

    // Use this for initialization
    void Start () {
        gameWin = gameObject.GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
		if (totalNPCs == ScoreScript.scoreValue)
        {
                gameWin.enabled = true;
        }
	}
}
