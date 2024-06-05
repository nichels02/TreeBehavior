using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class HealthBee : Health
{
   
    public int RecoleccionMaxima = 100;
    public int RecoleccionActual = 0;

    public override void Damage(int damage, Health healt)
    {
        base.Damage(damage, healt);

        if(IsDead)
        {
            //if (healt is HealthAvispa)
            // ((HealthAvispa)healt).
                
            Dead();
        }
;
    }
    public override void Dead()
    {

    }

}