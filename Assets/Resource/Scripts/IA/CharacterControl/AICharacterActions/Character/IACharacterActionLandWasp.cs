using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class IACharacterActionLandWasp : IACharacterActionLandAtack
{
    private void Start()
    {
        LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public override void atack()
    {
        base.atack();
    }

    protected override void LoMataste()
    {
        if (_health is HealthAvispa)
        {
            ((HealthAvispa)_health).hambre += 40;
        }
    }
}
