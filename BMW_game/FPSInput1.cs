using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput1 : MonoBehaviour
{
    public float speed = 20.0f;
    public float gravity = -9.8f;

    private CharacterController _charController;

    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed *= 1.5f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 20.0f;
        }
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(0, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement.y = gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
    }
}