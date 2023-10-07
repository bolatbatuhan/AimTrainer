using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float sensitivity = 2.0f; // Fare hassasiyeti
    public float maxYRotation = 80.0f; // Y ekseninde maksimum dönme açısı
    private float rotationX = 0;

    void Start()
    {

    }


    void Update()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Yatay (X ekseni) dönme için karakterin rotasyonunu güncelle
        transform.Rotate(Vector3.up * mouseX * sensitivity);

        // Dikey (Y ekseni) dönme için karakterin rotasyonunu güncelle
        rotationX -= mouseY * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -maxYRotation, maxYRotation);
        Camera.main.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }
}
