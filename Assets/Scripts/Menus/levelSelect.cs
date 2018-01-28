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

    public void OnMouseClickHospital()
    {
        //Application.LoadLevel(destination);
        SceneManager.LoadScene("Hospital");
    }
    public void OnMouseClickStreets()
    {
        //Application.LoadLevel(destination);
        SceneManager.LoadScene("Streets");
    }

    public void OnMouseClickReadme()
    {
        //Application.LoadLevel(destination);
        SceneManager.LoadScene("Readme");
    }
}
