using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    Abejas,
    Avispas,
    Flor,
    polen,
    carne,
    nulo
}

public class Health : MonoBehaviour
{
    [Header("Health")]

    public Colmena LaColmena;
    public Transform Hogar;
    public int life;
    public int lifeMax;
    public Transform AimOffset;
    public SpriteRenderer ElSprite;
    public UnitType MyUnitType;

    public UnitType ElTipoDeEnemigo;
    public UnitType ElTipoDeHuida;
    public UnitType ItemRecolectar;
    public bool Imortal = false;
    public bool FueAtacado = false;

    public float VelocidadMax;
    public float Velocidad;

    public Vector3 PosicionDondeAtacaron;

    public bool IsDead
    {
        get => life == 0;

    }
    public virtual void LoadComponent()
    {
        life = lifeMax;
        Velocidad = VelocidadMax;
    }
    public virtual bool Damage(int damage, Health healt)
    {
        if (Imortal) return false;
        FueAtacado = true;
        PosicionDondeAtacaron = healt.transform.position;
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