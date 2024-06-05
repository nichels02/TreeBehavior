using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion/RecoleccionCompleta")]
//NodoDeAccion
//NodoDeCondicion
public class ActionNotRecoleccionCompleta : ActionNodeAction
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
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction.health.IsDead)
            {
                return TaskStatus.Failure;
            }
        }

        if (_IACharacterVehicle != null)
        {
            if(_IACharacterVehicle.health is HealthBee)
            {
                if(((HealthBee)_IACharacterVehicle.health).RecoleccionActual <= ((HealthBee)_IACharacterVehicle.health).RecoleccionMaxima)
                {
                    return TaskStatus.Success;
                }
            }
        }
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction.health is HealthBee)
            {
                if (((HealthBee)_IACharacterAction.health).RecoleccionActual <= ((HealthBee)_IACharacterAction.health).RecoleccionMaxima)
                {
                    return TaskStatus.Success;
                }
            }
        }

        return TaskStatus.Failure;
    }
}