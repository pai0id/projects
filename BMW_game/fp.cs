using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fp : MonoBehaviour
{
    public Camera cam;
    bool on = true;
    void Update()
    {
        if (on == true)
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                cam.gameObject.SetActive(on);
                on = false;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                cam.gameObject.SetActive(on);
                on = true;
            }
        }
    }
}
