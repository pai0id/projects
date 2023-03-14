using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engine : MonoBehaviour {
    public AudioSource aud;
    void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            aud.enabled = !aud.enabled;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            aud.enabled = !aud.enabled;
        }
    }
}
