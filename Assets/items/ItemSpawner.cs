using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] GameObject ElItemCarne;
    [SerializeField] GameObject ElItemPolen;



    public void GenerarPolen(Vector3 posicionCentral)
    {
        for(int i  = 0; i < 3; i++)
        {
            float x = Random.Range(-2, 2);
            float z = Random.Range(-2, 2);
            Vector3 PosicionRandom = new Vector3(x + posicionCentral.x, posicionCentral.y, posicionCentral.z + z);
            Instantiate(ElItemPolen, PosicionRandom, Quaternion.identity);

        }
    }
    public void GenerarCarne(Vector3 posicionCentral)
    {
        for (int i = 0; i < 3; i++)
        {
            float x = Random.Range(-2, 2);
            float z = Random.Range(-2, 2);
            Vector3 PosicionRandom = new Vector3(x + posicionCentral.x, posicionCentral.y, posicionCentral.z + z);
            Instantiate(ElItemCarne, PosicionRandom, Quaternion.identity);

        }
    }
}
