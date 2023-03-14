using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour {
    public float speed = -3.0f;

    private void Update()
    {
        transform.Translate(speed*Time.deltaTime,0,0);
    }
    private void OnTriggerEnter(Collider other)
    {
        speed = -speed;
    }
}
