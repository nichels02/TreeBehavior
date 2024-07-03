using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterActionLandBeeRecolector : IACharacterActionLandAtack
{
    public virtual void Gather()
    {

    }
    public virtual void Warn()
    {
        atack();
    }
    public virtual void LlamarALosGuerreros(Vector2 x)
    {
        health.LaColmena.AvisarGuerreras(x);
    }
    public virtual void Almacenar()
    {
        health.LaColmena.recursos += ((HealthBee)health).RecoleccionActual;
        ((HealthBee)health).RecoleccionActual = 0;
    }

    public override void atack()
    {
        base.atack();
    }

    protected override void LoMataste()
    {
        if (_health is HealthBee)
        {
            ((HealthBee)_health).RecoleccionActual += 40;
        }
    }
}
