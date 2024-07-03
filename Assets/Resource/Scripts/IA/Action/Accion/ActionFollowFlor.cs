using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeAccion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionFollowFlor : ActionNodeAction
{
    public override void OnStart()
    {
        base.OnStart();
    }

    public override TaskStatus OnUpdate()
    {
        if (_IACharacterVehicle._health.IsDead)
        {
            return TaskStatus.Failure;
        }
        if (_IACharacterVehicle._AIVision.EnemyView != null)
        {
            if (_IACharacterVehicle._AIVision.EnemyView.MyUnitType == UnitType.Flor)
            {
                _IACharacterVehicle.MoveToPosition(_IACharacterVehicle._AIVision.EnemyView.transform.position, _IACharacterVehicle._health.VelocidadMax / 2);
                return TaskStatus.Success;
            }
            else
            {
                return TaskStatus.Failure;
            }
        }

        //SwitchMoveToAllied();
        return TaskStatus.Failure;
    }
}