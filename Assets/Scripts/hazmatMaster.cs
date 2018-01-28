using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazmatMaster : MonoBehaviour
{
    public bool chasing;

    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer spriteRenderer;

    public float speed;

    private Rigidbody2D myRigidBody;

    public bool isWalking;
    private bool hasWalkZone;
    public float walkTime;
    public float waitTime;
    private float walkCounter;
    private float waitCounter;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;

    public Collider2D walkzone;

    private int walkDir;
    // Use this for initialization
    void Start()
    {
        chasing = false;

        myRigidBody = GetComponent<Rigidbody2D>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        getDir();

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite1;

        if (walkzone != null)
        {
            minWalkPoint = walkzone.bounds.min;
            maxWalkPoint = walkzone.bounds.max;
            hasWalkZone = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
         
            if (isWalking)
            {
            if (!chasing)
            {
                if (chasing == false)
                {
                    walkCounter -= Time.deltaTime;

                    switch (walkDir)
                    {
                        case 0:
                            //move up
                            myRigidBody.velocity = new Vector2(0, speed);
                            //checks y pos compated to bounded y
                            if (hasWalkZone && transform.position.y > maxWalkPoint.y)
                            {
                                isWalking = false;
                                waitCounter = waitTime;
                            }
                            break;
                        case 1:
                            //move up and to the right
                            myRigidBody.velocity = new Vector2(speed, speed);
                            //checks y compred to  max bounded y or x compared to max bounded x
                            if (hasWalkZone && transform.position.y > maxWalkPoint.y || transform.position.x > maxWalkPoint.x)
                            {
                                isWalking = false;
                                waitCounter = waitTime;
                            }
                            break;
                        case 2:
                            ////move to the right
                            myRigidBody.velocity = new Vector2(speed, 0);
                            //checks x compared to max bounded x
                            if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                            {
                                isWalking = false;
                                waitCounter = waitTime;
                            }
                            break;
                        case 3:
                            //move down and to the right
                            myRigidBody.velocity = new Vector2(speed, (speed * -1));
                            //checks y compared to min bounded y or x compared to max bounded x
                            if (hasWalkZone && transform.position.y < minWalkPoint.y || transform.position.x > maxWalkPoint.x)
                            {
                                isWalking = false;
                                waitCounter = waitTime;
                            }
                            break;
                        case 4:
                            //move down
                            myRigidBody.velocity = new Vector2(0, (speed * -1));
                            //checks y compared to min bounded y
                            if (hasWalkZone && transform.position.y < minWalkPoint.y)
                            {
                                isWalking = false;
                                waitCounter = waitTime;
                            }
                            break;
                        case 5:
                            //move down and to the left
                            myRigidBody.velocity = new Vector2((speed * -1), (speed * -1));
                            //checks y compared to min bounded y or x compared to min bounded x
                            if (hasWalkZone && transform.position.y < minWalkPoint.y || transform.position.x < minWalkPoint.x)
                            {
                                isWalking = false;
                                waitCounter = waitTime;
                            }
                            break;
                        case 6:
                            //move left
                            myRigidBody.velocity = new Vector2((speed * -1), 0);
                            //check x compared to min bounded x
                            if (hasWalkZone && transform.position.x < minWalkPoint.x)
                            {
                                isWalking = false;
                                waitCounter = waitTime;
                            }
                            break;
                        case 7:
                            //move up and to the left
                            myRigidBody.velocity = new Vector2((speed * -1), speed);
                            //checks y compared to max bounded y or x compared to min bounded x
                            if (hasWalkZone && transform.position.y > maxWalkPoint.y || transform.position.x < minWalkPoint.x)
                            {
                                isWalking = false;
                                waitCounter = waitTime;
                            }
                            break;
                    }


                    transform.up = myRigidBody.velocity.normalized;

                    if (walkCounter < 0)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                }
            }
            // sneeze
            if (spriteRenderer.sprite == sprite2)
            {
                isWalking = false;
                StartCoroutine(sneezed());
            }
        }
        else
        {
            if (chasing == false)
            {
                waitCounter -= Time.deltaTime;

                myRigidBody.velocity = Vector2.zero;

                if (waitCounter < 0)
                {
                    getDir();
                }
            }
        }
    }

    public void getDir()
    {
        walkDir = Random.Range(0, 8);
        isWalking = true;
        walkCounter = walkTime;
    }

  
    IEnumerator sneezed()
    {
        waitCounter = -1;
        chasing = false;
        sneezedetect child = GetComponentInChildren<sneezedetect>();
        child.sneezing = true;
        yield return new WaitForSeconds(3f);
        spriteRenderer.sprite = sprite1;
        child.sneezing = false;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!chasing)
        {
            getDir();
        }

    }
}

