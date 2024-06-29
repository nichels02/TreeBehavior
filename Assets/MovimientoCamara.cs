using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del objeto

    void Update()
    {
        // Movimiento en los ejes X y Z
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // Debug para verificar valores
        Debug.Log("moveX: " + moveX + " moveZ: " + moveZ);

        // Aplicar movimiento al objeto
        transform.Translate(new Vector3(moveX, moveZ, 0f));
    }
}
