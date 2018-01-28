using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanable : MonoBehaviour {

    public bool clean;

	void Start () {
        clean = false;
        StartCoroutine(wait());
    }


    IEnumerator wait()
    {      
            yield return new WaitForSeconds(2f);
            clean = true;
    }
}
