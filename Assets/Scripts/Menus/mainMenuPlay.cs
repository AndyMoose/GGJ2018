using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseClick()
    {
        Application.LoadLevel("MainMenu");
    }
}
