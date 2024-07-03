using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class HealthBee : Health
{
   
    public int RecoleccionMaxima = 100;
    public int RecoleccionActual = 0;

    private void Start()
    {
        LoadComponent();
    }

    public override bool Damage(int damage, Health healt)
    {
        bool x = base.Damage(damage, healt);

        if(IsDead)
        {
            //if (healt is HealthAvispa)
            // ((HealthAvispa)healt).
                
            Dead();
        }
        return x;
    }
    public override void Dead()
    {
        LaColmena.murioUnaAbeja(transform.position);
        base.Dead();
    }

}