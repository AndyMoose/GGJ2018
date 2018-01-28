using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour
{

    public string destination;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseClick()
    {
        //Application.LoadLevel(destination);
        SceneManager.LoadScene(destination);
    }
}
