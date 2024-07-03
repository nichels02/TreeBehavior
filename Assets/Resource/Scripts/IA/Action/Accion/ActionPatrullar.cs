using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeAccion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionPatrullar : ActionNodeAction
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
        if (_IACharacterVehicle is IACharacterVehicleLandBeeSoldier)
        {
            if (_IACharacterVehicle.agent.remainingDistance <= _IACharacterVehicle.agent.stoppingDistance || _IACharacterVehicle.agent.destination == null)
            {
                ((IACharacterVehicleLandBeeSoldier)_IACharacterVehicle).Patrullaje();
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