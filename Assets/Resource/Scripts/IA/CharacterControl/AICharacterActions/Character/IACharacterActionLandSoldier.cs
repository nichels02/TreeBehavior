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
        //if (health is HealthAvispa)
        //{
        //    ((HealthAvispa)health).hambre += 40;
        //}
    }
}
