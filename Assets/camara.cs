using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float speedH = 2.0f; // velocidad horizontal
    public float speedV = 2.0f; // velocidad vertical

    private float yaw = 0.0f;   // rotación en Y
    private float pitch = 0.0f; // rotación en X

    void Update()
    {
        // sumamos la rotación horizontal según el movimiento del mouse
        yaw += speedH * Input.GetAxis("Mouse X");

        // restamos la rotación vertical (invertido para simular mirada natural)
        pitch -= speedV * Input.GetAxis("Mouse Y");

        // aplicamos la rotación a la cámara
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}