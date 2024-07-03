using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class HealthFlor : Health
{
    [SerializeField] ItemSpawner ElSpawner;
    private void Start()
    {
        LoadComponent();
    }

    public override bool Damage(int damage, Health healt)
    {
        bool x = base.Damage(damage, healt);

        if (IsDead)
        {
            //if (healt is HealthAvispa)
            // ((HealthAvispa)healt).
            

            Dead();
        }
        return x;
    }
    public override void Dead()
    {
        ElSpawner.GenerarPolen(transform.position);
        base.Dead();
    }

}