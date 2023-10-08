using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float sensitivity = 1.0f;
    private float rotationY = 80f;
    private Vector2 turn;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        turn.y = Mathf.Clamp(turn.y, -rotationY, rotationY);


    }
}
