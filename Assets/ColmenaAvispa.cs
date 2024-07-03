using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColmenaAvispa : MonoBehaviour
{
    [SerializeField] ItemSpawner ElItemSpawner;
    [SerializeField] int cantidadAvispas;
    public void murioUnaAbejaGuerrera(Vector3 x)
    {
        cantidadAvispas -= 1;
        ElItemSpawner.GenerarCarne(x);
    }
}
