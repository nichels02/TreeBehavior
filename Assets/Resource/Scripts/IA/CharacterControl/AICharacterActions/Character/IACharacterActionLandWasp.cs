using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class IACharacterActionLandWasp : IACharacterActionLandAtack
{
    public override void atack()
    {
        base.atack();
    }

    protected override void LoMataste()
    {
        if (health is HealthAvispa)
        {
            ((HealthAvispa)health).hambre += 40;
        }
    }
}
