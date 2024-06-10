using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterActionLandBeeRecolector : IACharacterActionLandAtack
{
    public override void Gather()
    {
        base.Gather();
    }
    public override void Warn()
    {
        base.Warn();
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
