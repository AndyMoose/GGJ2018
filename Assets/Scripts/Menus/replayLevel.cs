using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replayLevel : MonoBehaviour {
    public void OnMouseClick()
    {
        Application.LoadLevel(Application.loadedLevelName);
    }
}
