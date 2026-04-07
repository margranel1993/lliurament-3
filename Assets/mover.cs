using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public Rigidbody jugador;
    public float velocidad = 100;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
           
            jugador.AddForce(velocidad* Time.deltaTime, 0, 0);
       
        if (Input.GetKey(KeyCode.S))

            jugador.AddForce(-velocidad * Time.deltaTime, 0, 0);

    }
}
