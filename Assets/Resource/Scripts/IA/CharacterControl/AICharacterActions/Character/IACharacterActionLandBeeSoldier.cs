using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterActionLandBeeSoldier : IACharacterActionLandAtack
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

        }
    }
}
