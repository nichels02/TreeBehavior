using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colmena : MonoBehaviour
{
    public float recursos;
    public int recursosMin;

    public int CantidadDeRecolectoras;
    public int CantidadDeGuerreras;

    public int CostoRecolectora;
    public int CostoGuerrera;

    Action<Vector2> LLamarALasGuerreras;

    GameObject Recolectora;
    GameObject Guerrera;


    private void Start()
    {
        StartCoroutine(ReducirRecursos());
    }
    private void Update()
    {
        if(recursos> recursosMin)
        {
            if (CantidadDeRecolectoras < 10)
            {
                GenerarRecolectora();
            }
            if (CantidadDeGuerreras < 10)
            {
                GenerarGuerrera();
            }
        }
        
    }
    
    public void AvisarGuerreras(Vector2 x)
    {
        LLamarALasGuerreras?.Invoke(x);
    }


    public void murioUnaAbeja()
    {
        CantidadDeRecolectoras -= 1;
    }
    public void murioUnaAbejaGuerrera()
    {
        CantidadDeGuerreras -= 1;
    }


    public void GenerarRecolectora()
    {

    }
    public void GenerarGuerrera()
    {

    }



    public void RecibirRecursos(int RecusosRecividos)
    {
        recursos += RecusosRecividos;

    }
    IEnumerator ReducirRecursos()
    {
        bool x = false;
        while (x == false)
        {
            yield return new WaitForSeconds(1f);
            recursos -= recursos > 0 ? 0.5f : 0;
        }
    }
}
