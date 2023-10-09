using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float sensivity = 1.5f;
    private float rotationY = 80.0f;
    Vector2 turn;
    private void Start()
    {
        Cursor.lockState  = CursorLockMode.Locked;
        transform.localRotation = Quaternion.Euler(0,5,0);
    }

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        turn.x += Input.GetAxisRaw("Mouse X") * sensivity;
        turn.y += Input.GetAxisRaw("Mouse Y") * sensivity;
        turn.y = Mathf.Clamp(turn.y,-rotationY,rotationY);
        transform.localRotation = Quaternion.Euler(-turn.y,turn.x,0);
    }
}
