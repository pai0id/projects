using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    bool isoff = true;
    int angle = 0;
	void Update () {
        if (Input.GetAxis("Mouse X") < 0)
        {
            if (isoff)
            {
                angle = 15;
                transform.Rotate(angle, 0, 0);
                isoff = !isoff;
            }
        }
        else if (Input.GetAxis("Mouse X") > 0)
        {
            if(isoff)
            {
                angle = -15;
                transform.Rotate(angle, 0, 0);
                isoff = !isoff;
            }
        }
        else
        {
            if (!isoff)
            {
                transform.Rotate(-angle, 0, 0);
                isoff = !isoff;
            }
        }
    }
}
