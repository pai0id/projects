using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public float speed = 30f;
	void Update () {
        StartCoroutine(bull());  
	}
    private IEnumerator bull()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
