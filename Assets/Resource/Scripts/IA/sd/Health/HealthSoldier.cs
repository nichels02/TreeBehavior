using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class HealthSoldier : Health
{
    public bool fueAdvertido;
    public Vector3 posicionAdvertida;
    private void Start()
    {
        LoadComponent();

    }
    public void advertir(Vector3 x)
    {
        posicionAdvertida = x;
        fueAdvertido = true;
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
        LaColmena.LLamarALasGuerreras -= advertir;
        LaColmena.murioUnaAbejaGuerrera(transform.position);
        base.Dead();
    }

}