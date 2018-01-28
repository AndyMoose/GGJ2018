using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loseCondition : MonoBehaviour
{
    private Canvas gameLoss;
    AudioSource trombone;
    public bool isLosing;
    public Canvas win;
    private bool soundPlayed;

    void Start()
    {
        gameLoss = gameObject.GetComponent<Canvas>();
        trombone = GetComponent<AudioSource>();
        soundPlayed = false;
        isLosing = false;
    }

    void Update()
    {
        if (isLosing == true && win.GetComponent<winCondition>().won == false)
        {
            gameLoss.enabled = true;
            if (trombone.isPlaying == false && soundPlayed == false)
            {
                trombone.PlayOneShot(trombone.clip,1f);
                soundPlayed = true;
            }
        }

        isLosing = GameObject.Find("Player").GetComponent<playerLoseCollision>().collisionLoss;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

    }
}
