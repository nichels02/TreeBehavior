using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del objeto
    public float LimiteMax = 200; 
    public float LimiteMin = -200; 

    void Update()
    {
        // Movimiento en los ejes X y Z
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // Debug para verificar valores
        //Debug.Log("moveX: " + moveX + " moveZ: " + moveZ);

        // Aplicar movimiento al objeto
        transform.Translate(new Vector3(moveX+ transform.position.x > LimiteMax? LimiteMax : moveX + transform.position.x < LimiteMin? LimiteMin : moveX, 
                                        moveZ + transform.position.y > LimiteMax ? LimiteMax : moveZ + transform.position.y < LimiteMin ? LimiteMin : moveZ, 0f));
    }
}
