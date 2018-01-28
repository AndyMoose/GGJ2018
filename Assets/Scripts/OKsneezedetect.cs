using UnityEngine;
using System.Collections;

// rotations exist entirely on z axis, negative to normalize
// have z axis on hazmat point to player

public class OKsneezedetect : MonoBehaviour
{
    public Transform playerLocation;
    public Transform hazmatLocation;

    public bool isChasing;


    Quaternion rotation;

    private float rotateSpeed = 360f;

    private void Start()
    {
        isChasing = GameObject.Find("hazmat").GetComponent<hazmatMaster>().chasing;
        Debug.Log(isChasing); //true

    }

    private void Update()
    {
        if (isChasing == true)
        {
            GameObject.Find("hazmat").GetComponent<hazmatMaster>().chasing = true;
            transform.LookAt(playerLocation);
        } else if (isChasing == false)
        {
            GameObject.Find("hazmat").GetComponent<hazmatMaster>().chasing = false;

        }

        Vector3 distanceBetween = playerLocation.transform.position - hazmatLocation.transform.position;
        Quaternion rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(distanceBetween), rotateSpeed * Time.deltaTime);
        hazmatLocation.transform.rotation = rotation;
        hazmatLocation.transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
          //  isChasing = true;
            Debug.Log("Player detected.");
            hazmatLocation.transform.rotation = rotation;

        } else
        {
           // isChasing = false;
        }
    }

}