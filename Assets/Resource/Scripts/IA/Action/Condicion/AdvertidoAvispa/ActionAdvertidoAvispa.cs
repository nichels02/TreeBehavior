using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[TaskCategory("IA SC/NodoDeCondicion/AdvertidoAvispa")]


public class ActionAdvertidoAvispa : ActionNodeAction
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_IACharacterVehicle != null && _IACharacterVehicle._health.IsDead)
        {
            return TaskStatus.Failure;
        }
        else if (_IACharacterAction != null && _IACharacterAction._health.IsDead)
        {
            return TaskStatus.Failure;
        }



        if (_IACharacterVehicle != null)
        {
            if(_IACharacterVehicle._health != null)
            {
                if (_IACharacterVehicle._health is HealthSoldier)
                {
                    if (((HealthSoldier)_IACharacterVehicle._health).fueAdvertido)
                    {
                        return TaskStatus.Success;
                    }
                }
            }
        }
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction._health != null)
            {
                if (_IACharacterAction._health is HealthSoldier)
                {
                    if (((HealthSoldier)_IACharacterAction._health).fueAdvertido)
                    {
                        return TaskStatus.Success;
                    }
                }
            }
        }






        return TaskStatus.Failure;
    }
}