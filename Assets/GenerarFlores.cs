using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarFlores : MonoBehaviour
{
    [SerializeField] GameObject flor;
    [SerializeField] ItemSpawner itemSpawner;
    [SerializeField] Vector3 Min;
    [SerializeField] Vector3 Max;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GenerarFlor();
        }
        StartCoroutine(GeneracionAuto());

    }


    public void GenerarFlor()
    {
        Vector3 x = new Vector3(Random.Range(Min.x, Max.x), 0 , Random.Range(Min.z, Max.z));

        GameObject laflor = Instantiate(flor, x, Quaternion.identity);
        laflor.GetComponent<HealthFlor>().ElSpawner = itemSpawner;
    }
    IEnumerator GeneracionAuto()
    {
        yield return new WaitForSeconds(10);
        GenerarFlor();
    }
}
