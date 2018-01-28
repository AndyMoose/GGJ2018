using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loseCondition : MonoBehaviour
{
    private Canvas gameLoss;
    AudioSource trombone;
    public bool isLosing = false;

    void Start()
    {
        gameLoss = gameObject.GetComponent<Canvas>();
        trombone = GetComponent<AudioSource>();
    }

    void Update()
    {
        bool isLosing = GameObject.Find("Player").GetComponent<playerLoseCollision>().collisionLoss;

        if (isLosing == true)
        {
            gameLoss.enabled = true;
            if (trombone.isPlaying == false)
            {
                trombone.Play();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

    }
}
