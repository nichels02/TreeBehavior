using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterActionLandSoldier : IACharacterActionLandAtack
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void atack()
    {
        base.atack();
    }

    protected override void LoMataste()
    {
        //if (Health is HealthAvispa)
        //{
        //    ((HealthAvispa)Health).hambre += 40;
        //}
    }
}
