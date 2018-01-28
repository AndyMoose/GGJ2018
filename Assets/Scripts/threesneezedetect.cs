using UnityEngine;
using System.Collections;

public class threesneezedetect : MonoBehaviour
{
    public Transform hazmatTransform;
    public Transform playerTransform;

    void Start()
    {
       
    }

    void Update()
    {
        Vector3 vectorToTarget = hazmatTransform.position - playerTransform.position;
        float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg)+90;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 180);
    }
}