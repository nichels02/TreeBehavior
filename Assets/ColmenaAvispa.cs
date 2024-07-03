using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColmenaAvispa : MonoBehaviour
{
    [SerializeField] ItemSpawner ElItemSpawner;
    [SerializeField] GameObject avispa;
    [SerializeField] int cantidadAvispas;

    private void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            GenerarAvispa();
        }
    }
    public void GenerarAvispa()
    {
        GameObject LaAvispa = Instantiate(avispa, transform.position, Quaternion.identity);
        LaAvispa.GetComponent<HealthAvispa>().LaColmenaAvispa = this;
        LaAvispa.GetComponent<HealthAvispa>().Hogar= transform;
    }
    public void murioUnaAbejaGuerrera(Vector3 x)
    {
        GenerarAvispa();
        ElItemSpawner.GenerarCarne(x);
    }
}
