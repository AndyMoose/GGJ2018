using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {

    public Transform player;

    public float leftBound;
    public float rightBound;
    public float bottomBound;
    public float topBound;

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(player.position.x, player.position.y, -30);

        var pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        pos.x = Mathf.Clamp(pos.x, leftBound, rightBound);
        pos.y = Mathf.Clamp(pos.y, bottomBound, topBound);
        transform.position = pos;
    }
}
