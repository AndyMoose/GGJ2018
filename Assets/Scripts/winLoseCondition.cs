using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winLoseCondition : MonoBehaviour {

    public int totalNPCs;
    //private NPCcontroller infectedNPCs;

    private Image gameWin;

    // Use this for initialization
    void Start () {
        gameWin = gameObject.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (totalNPCs == ScoreScript.scoreValue)
        {
                gameWin.enabled = true;
        }
	}
}
