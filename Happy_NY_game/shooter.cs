using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {
    [SerializeField] private GameObject bulletprefab;
    private GameObject _bullet;
	void Update ()
    {
		if(Input.GetMouseButtonDown(0))
        {
            _bullet = Instantiate(bulletprefab) as GameObject;
            _bullet.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
            _bullet.transform.rotation = transform.rotation;
        }
	}
}
