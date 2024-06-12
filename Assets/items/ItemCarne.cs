using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCarne : item
{

    [SerializeField] int Vida;
    [SerializeField] int hambre;



    public override void AlColicionar(Health health)
    {
        

        if(health is HealthAvispa)
        {
            ((HealthAvispa)health).hambre = ((HealthAvispa)health).hambre + hambre <= 100 ? 100 : ((HealthAvispa)health).hambre + hambre;
            ((HealthAvispa)health).life = ((HealthAvispa)health).life + Vida <= 100 ? 100 : ((HealthAvispa)health).life + Vida;
            Destroy(gameObject);
        }

    }
}
