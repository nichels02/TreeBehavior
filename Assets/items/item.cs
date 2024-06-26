using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class item : MonoBehaviour
{
    public UnitType MyUnitTypeObject;
    public abstract void AlColicionar(Health Health);
}
