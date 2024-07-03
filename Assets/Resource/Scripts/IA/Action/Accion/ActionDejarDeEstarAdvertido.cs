using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeAccion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionDejarDeEstarAdvertido : ActionNodeAction
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_IACharacterVehicle != null)
        {
            if (_IACharacterVehicle._health.IsDead)
            {
                return TaskStatus.Failure;
            }
        }
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction._health.IsDead)
            {
                return TaskStatus.Failure;
            }
        }


        if (_IACharacterVehicle != null)
        {
            if (_IACharacterVehicle._health is HealthSoldier)
            {
                if (((HealthSoldier)_IACharacterVehicle._health).fueAdvertido)
                {
                    ((HealthSoldier)_IACharacterVehicle._health).fueAdvertido = false;
                    return TaskStatus.Success;
                }
            }
        }
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction._health is HealthSoldier)
            {
                if (((HealthSoldier)_IACharacterAction._health).fueAdvertido)
                {
                    ((HealthSoldier)_IACharacterAction._health).fueAdvertido = false;
                    return TaskStatus.Success;
                }
            }
        }

        return TaskStatus.Failure;
    }
}
