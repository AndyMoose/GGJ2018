using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loseCondition : MonoBehaviour
{
    private Canvas gameLoss;

    void Start()
    {
        gameLoss = gameObject.GetComponent<Canvas>();
    }

    void Update()
    {
        if (GetComponent<Collider>().Equals("hazmat"))
        {
            gameLoss.enabled = true;
        }
    }
}
