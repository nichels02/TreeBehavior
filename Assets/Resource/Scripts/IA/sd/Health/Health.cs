using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    Abejas,
    Avispas,
    Flor,
    nulo
}

public class Health : MonoBehaviour
{
    public Transform Hogar;
    public int life;
    public int lifeMax;
    public Transform AimOffset;
    public SpriteRenderer ElSprite;
    public UnitType MyUnitType;


    public UnitType ElTipoDeEnemigo;
    public UnitType ElTipoDeHuida;

    public bool Imortal = false;
    public bool IsDead
    {
        get => life == 0;

    }
    public virtual void LoadComponent()
    {
        life = lifeMax;
    }
    public virtual bool Damage(int damage, Health healt)
    {
        if (Imortal) return false;

        if ((life - damage) > 0)
        {
            life -= damage;
            StartCoroutine(CambiarColor());
            return false;
        }
        else
        {
            life = 0;
            return true;
        }
    }

    
    IEnumerator CambiarColor()
    {
        Color ELColor = ElSprite.color;
        ElSprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        ElSprite.color = ELColor;

    }
    public virtual void Dead()
    {
        StartCoroutine(LaDestruccion());
    }


    public IEnumerator LaDestruccion()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    } 

}