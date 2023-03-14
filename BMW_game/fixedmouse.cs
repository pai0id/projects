using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixedmouse : MonoBehaviour {
    private Camera _camera;
    private void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void OnGUI()
    {
        int size = 12;
        float posx = _camera.pixelWidth / 2 - size / 4;
        float posy = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posx, posy, size, size), "*");
    }
}
