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
            ((HealthBee)Health).RecoleccionActual = ((HealthBee)Health).RecoleccionActual + Recoleccion <= 100 ? 100 : ((HealthBee)Health).RecoleccionActual + Recoleccion;
            Destroy(gameObject);
        }
    }
}
