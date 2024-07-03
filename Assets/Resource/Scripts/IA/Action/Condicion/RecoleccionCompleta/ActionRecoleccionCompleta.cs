using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion/RecoleccionCompleta")]
//NodoDeAccion
//NodoDeCondicion
public class ActionRecoleccionCompleta : ActionNodeAction
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
            if (_IACharacterVehicle._health is HealthBee)
            {
                if (((HealthBee)_IACharacterVehicle._health).RecoleccionActual >= ((HealthBee)_IACharacterVehicle._health).RecoleccionMaxima)
                {
                    return TaskStatus.Success;
                }
            }
        }
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction._health is HealthBee)
            {
                if (((HealthBee)_IACharacterAction._health).RecoleccionActual >= ((HealthBee)_IACharacterAction._health).RecoleccionMaxima)
                {
                    return TaskStatus.Success;
                }
            }
        }

        return TaskStatus.Failure;
    }
}