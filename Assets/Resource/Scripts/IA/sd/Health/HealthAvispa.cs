using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class HealthAvispa : Health
{
    public ColmenaAvispa LaColmenaAvispa;
    public int hambre=50;
    public int hambreMax=100;

    private void Start()
    {
        LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
        StartCoroutine(ReducirHambre());
    }

    IEnumerator ReducirHambre()
    {
        while (!IsDead)
        {
            hambre -= hambre > 0 ? 1 : 0;
            yield return new WaitForSeconds(1f);
        }
        
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
        base.Dead();
    }


}