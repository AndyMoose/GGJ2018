using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Movement : MonoBehaviour {

    public float speed;

    private Rigidbody2D myRigidBody;

    public bool isWalking;
    public float walkTime;
    public float waitTime;
    private float walkCounter;
    private float waitCounter;
    private Vector3 moveDirection = Vector3.zero;

    private int walkDir;
	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        getDir();
	}
	
	// Update is called once per frame
	void Update () {
		if (isWalking)
        {
            walkCounter -= Time.deltaTime;

            switch (walkDir)
            {
            case 0:
                    myRigidBody.velocity = new Vector2(0, speed);
                    break;
            case 1:
                    myRigidBody.velocity = new Vector2(speed, speed);                    
                    break;
            case 2:
                    myRigidBody.velocity = new Vector2(speed, 0);
                break;
            case 3:
                    myRigidBody.velocity = new Vector2(speed, (speed * -1));
                break;
            case 4:
                    myRigidBody.velocity = new Vector2(0, (speed * -1));
                break;
            case 5:
                    myRigidBody.velocity = new Vector2((speed * -1), (speed * -1));
                break;
            case 6:
                    myRigidBody.velocity = new Vector2((speed * -1), 0);
                break;
            case 7:
                    myRigidBody.velocity = new Vector2((speed * -1), speed);
                break;
            }

            transform.up = myRigidBody.velocity.normalized;
    
            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }
        }
        else
        {
            waitCounter -= Time.deltaTime;

            myRigidBody.velocity = Vector2.zero;

            if(waitCounter < 0)
            {
                getDir();
            }
        }
	}

    public void getDir()
    {
        walkDir = Random.Range(0, 8);
        isWalking = true;
        walkCounter = walkTime;
    }
}
