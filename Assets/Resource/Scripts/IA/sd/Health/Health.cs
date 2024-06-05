using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    Abejas,
    Avispas,
    Flor 
}

public class Health : MonoBehaviour
{
    public int life;
    public int lifeMax;
    public Transform AimOffset;
    public UnitType UnitType;

    public bool Imortal = false;
    public bool IsDead
    {
        get => life == 0;

    }
    public virtual void LoadComponent()
    {
        life = lifeMax;
    }
    public virtual void Damage(int damage, Health healt)
    {
        if (Imortal) return;

        if ((life - damage) > 0)
            life -= damage;
        else
            life = 0;

    }

    public virtual void Dead()
    {

    }
}