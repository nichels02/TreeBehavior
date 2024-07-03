using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPolen : item
{
    [SerializeField] int Recoleccion;
    public override void AlColicionar(Health Health)
    {
        if (Health is HealthBee)
        {
            ((HealthBee)Health).RecoleccionActual += Recoleccion;
            Destroy(gameObject);
        }
    }
}
