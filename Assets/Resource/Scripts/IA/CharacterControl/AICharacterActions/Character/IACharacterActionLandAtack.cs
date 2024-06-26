using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterActionLandAtack : IACharacterActionLand
{
    public int damage;
    private void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
        

    }
    public override void atack()
    {
        if (_AIVision is VisionSensorAttack && ((VisionSensorAttack)_AIVision).MainVisionAttack.InSight)
        {
            if (((VisionSensorAttack)_AIVision).EnemyView != null)
            {
                if(((VisionSensorAttack)_AIVision).EnemyView.Damage(damage, _health))
                {
                    LoMataste();
                }
            }
        }

    }
    protected virtual void LoMataste()
    {

    }
}
