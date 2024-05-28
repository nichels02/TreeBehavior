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
    public Transform AimOffset;
    public UnitType UnitType;
    public int RecoleccionMaxima = 100;
    public int RecoleccionActual = 0;

    public bool IsDead
    {
        get => life == 0;

    }
}