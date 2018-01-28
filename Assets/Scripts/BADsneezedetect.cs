using UnityEngine;
using System.Collections;

// rotations exist entirely on z axis, negative to normalize
// have z axis on hazmat point to player

public class BADsneezedetect : MonoBehaviour
{

    // Stores location data for player and hazmat
    public Transform playerLocation;
    public Transform hazmatLocation;

    private Vector2 playerX;
    private Vector2 playerY;
    private Vector2 hazmatX;
    private Vector2 hazmatY;

    public bool isChasing;

    GameObject hazmatGuy = GameObject.Find("hazmat");

    // Changes speed at which hazmat rotats to follow player
    private float rotateSpeed = 360f;

    // Math math math
    private float angle;

    // Use this for initialization
    void Start()
    {
        // Create reference chasing bool in hazmatMaster
        isChasing = GameObject.Find("hazmat").GetComponent<hazmatMaster>().chasing;
        Debug.Log(isChasing);


        // Initialize locations

    }

    // Update is called once per frame
    void Update()
    {
        // So long as chasing is true, it doesn't matter if walking is T or F
        if (isChasing == true)
        {
            GameObject.Find("hazmat").GetComponent<hazmatMaster>().chasing = true;
            transform.LookAt(playerLocation);
        } else if (isChasing == false)
        {
            GameObject.Find("hazmat").GetComponent<hazmatMaster>().chasing = false;

        }

        // please kill me
        //Vector3 relativePosition = playerLocation.position - hazmatLocation.position;
        //Quaternion rotato = Quaternion.LookRotation(relativePosition);

        // transform.LookAt(playerLocation);

        //Vector2 vectorToTarget = playerLocation.position - hazmatLocation.position;
        //float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        //Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
       // transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 50);

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // the hunt is on...
            isChasing = true;

            //GameObject.Find("hazmat").transform.LookAt(playerLocation); // FREEZES NORTH


            //this.transform.LookAt(playerLocation); // DONT DO THIS IT BREAKS SHIT

            Debug.Log("Player detected.");
         

            //angle = Mathf.Atan2(vectorTarget.y, vectorTarget.x) * Mathf.Rad2Deg;
            //Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            //transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotateSpeed);
            //transform.LookAt(transform.position + new Vector3(0, 0, 1), vectorTarget);
        } else
        {
            // but only when in the collision zone
            isChasing = false;
        }
    }

}