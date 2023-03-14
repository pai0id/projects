using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recoil : MonoBehaviour {
    private IEnumerator recoil1()
    {
        StartCoroutine(recoil2());
        yield return new WaitForSeconds(0.2f);
        transform.Rotate(11, 0, 0);
    }
    private IEnumerator recoil2()
    {
        yield return new WaitForSeconds(0.1f);
        transform.Rotate(-11, 0, 0);
    }
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(recoil1());
        }
	}
}
