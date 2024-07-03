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

    public Action<Vector3> LLamarALasGuerreras;

    [SerializeField] GameObject Recolectora;
    [SerializeField] GameObject Guerrera;

    [SerializeField] ItemSpawner ElItemSpawner;


    private void Start()
    {
        StartCoroutine(ReducirRecursos());
        for(int i = 0; i < 2; i++)
        {
            GenerarRecolectora();
        }
        for (int i = 0; i < 2; i++)
        {
            GenerarGuerrera();
        }
    }
    private void Update()
    {
        if(recursos> recursosMin)
        {
            if (CantidadDeRecolectoras < 10)
            {
                recursos -= recursosMin;
                GenerarRecolectora();
            }
            if (CantidadDeGuerreras < 10)
            {
                recursos -= recursosMin;
                GenerarGuerrera();
            }
            
        }
        
    }
    
    public void AvisarGuerreras(Vector3 x)
    {
        LLamarALasGuerreras?.Invoke(x);
    }


    public void murioUnaAbeja(Vector3 x)
    {
        CantidadDeRecolectoras -= 1;
        ElItemSpawner.GenerarCarne(x);

    }
    public void murioUnaAbejaGuerrera(Vector3 x)
    {
        CantidadDeGuerreras -= 1;
        ElItemSpawner.GenerarCarne(x);
    }


    public void GenerarRecolectora()
    {
        Vector3 x = new Vector3(UnityEngine.Random.Range(-10, 10), 0, UnityEngine.Random.Range(-10, 10));
        GameObject LaRecolectora = Instantiate(Recolectora, transform.position+ x, Quaternion.identity);
        LaRecolectora.GetComponent<Health>().LaColmena = this;
        LaRecolectora.GetComponent<Health>().Hogar = transform;
    }
    public void GenerarGuerrera()
    {
        Vector3 x = new Vector3(UnityEngine.Random.Range(-10, 10), 0, UnityEngine.Random.Range(-10, 10));
        GameObject LaRecolectora = Instantiate(Guerrera, transform.position + x, Quaternion.identity);
        LaRecolectora.GetComponent<Health>().LaColmena = this;
        LaRecolectora.GetComponent<Health>().Hogar = transform;

        LLamarALasGuerreras += LaRecolectora.GetComponent<HealthSoldier>().advertir;
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
