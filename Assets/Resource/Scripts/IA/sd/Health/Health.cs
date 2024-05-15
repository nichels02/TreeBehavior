using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    Terroristas,
    Antiterroristas
}

public class Health : MonoBehaviour
{
    public int life;
    public Transform AimOffset;
    public UnitType UnitType;

    public bool IsDead
    {
        get => life == 0;

    }
}