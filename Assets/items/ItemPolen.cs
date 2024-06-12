using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPolen : item
{
    [SerializeField] int Recoleccion;
    public override void AlColicionar(Health health)
    {
        if (health is HealthBee)
        {
            ((HealthBee)health).RecoleccionActual = ((HealthBee)health).RecoleccionActual + Recoleccion <= 100 ? 100 : ((HealthBee)health).RecoleccionActual + Recoleccion;
            Destroy(gameObject);
        }
    }
}
