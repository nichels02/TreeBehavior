using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeAccion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionFollowEnemy : ActionNodeAction
{
    public override void OnStart()
    {
        base.OnStart();
    }

    public override TaskStatus OnUpdate()
    {
        if (_IACharacterVehicle.health.IsDead)
        {
            return TaskStatus.Failure;
        }

        
        _IACharacterVehicle.MoveToEnemy();
        //SwitchMoveToAllied();
        return TaskStatus.Success;
    }
}