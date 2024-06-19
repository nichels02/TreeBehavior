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

    public override void atack()
    {
        base.atack();
    }

    protected override void LoMataste()
    {
        if (health is HealthBee)
        {
            ((HealthBee)health).RecoleccionActual += 40;
        }
    }
}
