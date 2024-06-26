using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCarne : item
{
    
    [SerializeField] int Vida;
    [SerializeField] int hambre;



    public override void AlColicionar(Health Health)
    {
        

        if(Health is HealthAvispa)
        {
            ((HealthAvispa)Health).hambre = ((HealthAvispa)Health).hambre + hambre <= 100 ? 100 : ((HealthAvispa)Health).hambre + hambre;
            ((HealthAvispa)Health).life = ((HealthAvispa)Health).life + Vida <= 100 ? 100 : ((HealthAvispa)Health).life + Vida;
            Destroy(gameObject);
        }

    }
}
