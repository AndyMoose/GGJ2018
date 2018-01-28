using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float runSpeed;

    private float xMin, xMax, yMin, yMax;
    private new Rigidbody2D rigidbody;

    public GameObject snot;
    public Transform snotPos;

    public float fireRate;
    private float nextFire;
    private float timer;

    AudioSource sneeze1;
    AudioSource sneeze2;
    AudioSource sneeze3;

    private void Start()
    {
        AudioSource[] audios = GetComponents<AudioSource>();
        sneeze1 = audios[0];
        sneeze2 = audios[1];
        sneeze3 = audios[2];
    }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
       // xMin = -11f;
       // xMax = 8f;
       // yMin = -9f;
       // yMax = 10f;
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            Quaternion noRotate = transform.rotation;
            Vector2 stayStill = transform.position;
            nextFire = Time.time + fireRate;
            Instantiate(snot, snotPos.position, snotPos.rotation);

            int index = Random.Range(0, 2);
            if (index == 0)
            {
                sneeze1.Play();
            }
            else if (index == 1)
            {
                sneeze2.Play();
            }
            else if (index == 2)
            {
                sneeze3.Play();
            }

            StartCoroutine(PauseMovement());
        }


    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rigidbody.velocity = movement * speed;

        //rigidbody.position = new Vector2(
        //    Mathf.Clamp(rigidbody.position.x, xMin, xMax),
        //    Mathf.Clamp(rigidbody.position.y, yMin, yMax)
        //    );

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

        if (Input.GetKey(KeyCode.LeftShift) == true)
        {
            rigidbody.velocity = movement * runSpeed;
        }
        else
        {
            rigidbody.velocity = movement * speed;
        }

    }

    IEnumerator PauseMovement()
    {
        //Backup and clear velocities
        Vector3 linearBackup = rigidbody.velocity;
        rigidbody.velocity = Vector3.zero;

        //Finally freeze the body in place so forces like gravity or movement won't affect it
        rigidbody.constraints = RigidbodyConstraints2D.FreezeAll;

        //Wait for a bit (two seconds)
        yield return new WaitForSeconds(0.5f);
        //And unfreeze before restoring velocities
        rigidbody.constraints = RigidbodyConstraints2D.None;
        //restore the velocities
        rigidbody.velocity = linearBackup;
    }
}