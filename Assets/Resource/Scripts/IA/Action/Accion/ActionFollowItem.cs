using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeAccion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionFollowItem : ActionNodeAction
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
        if (((VisionSensorAttack)_IACharacterVehicle._AIVision).ElItem != null)
        {
            if (((VisionSensorAttack)_IACharacterVehicle._AIVision).ElItem.MyUnitTypeObject == _IACharacterVehicle._health.ItemRecolectar)
            {
                _IACharacterVehicle.MoveToPosition(((VisionSensorAttack)_IACharacterVehicle._AIVision).ElItem.transform.position, _IACharacterVehicle._health.VelocidadMax / 2);
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