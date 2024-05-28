using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionLLegoAlDestino : ActionNodeAction
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_IACharacterVehicle != null)
        {
            if (_IACharacterVehicle.health.IsDead)
            {
                return TaskStatus.Failure;
            }
        }

        if (_IACharacterVehicle != null)
        {
            if (_IACharacterVehicle.agent.remainingDistance <= _IACharacterVehicle.agent.stoppingDistance)
            {
                return TaskStatus.Success;
            }
            else if (_IACharacterVehicle.agent.destination == null)
            {
                return TaskStatus.Success;
            }
        }
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction.agent.remainingDistance <= _IACharacterAction.agent.stoppingDistance)
            {
                return TaskStatus.Success;
            }
            else if (_IACharacterVehicle.agent.destination == null)
            {
                return TaskStatus.Success;
            }
        }

        return TaskStatus.Failure;
    }
}