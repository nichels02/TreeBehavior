using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeAccion")]


public class ActionRecogerObjeto : ActionNodeAction
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_IACharacterVehicle._health.IsDead || _IACharacterAction._health.IsDead)
        {
            return TaskStatus.Failure;
        }
        if(_IACharacterAction is IACharacterActionLand)
        {
            ((IACharacterActionLand)_IACharacterAction).RecogerItem();
        }

        return TaskStatus.Success;
    }

}


