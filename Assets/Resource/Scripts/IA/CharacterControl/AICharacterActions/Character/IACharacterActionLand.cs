using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterActionLand : IACharacterAction
{
    protected WeaponsManager _WeaponsManager;

    public override void LoadComponent()
    {
        base.LoadComponent();
        _WeaponsManager = GetComponent<WeaponsManager>();

    }


    #region Action

    public virtual void FirePlay()
    {
        _WeaponsManager.Fire();
    }

    public virtual void StopFire()
    {
        _WeaponsManager.StopFire();
    }
    public virtual void atack()
    {

    }
    public virtual void RecogerItem()
    {
        ((VisionSensorAttack)AIVision).ElItemAtaque.AlColicionar(health);
    }
    #endregion
}
