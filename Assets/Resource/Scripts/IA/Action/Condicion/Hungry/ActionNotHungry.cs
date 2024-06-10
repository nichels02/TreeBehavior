using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion/Hungry")]
//NodoDeAccion
//NodoDeCondicion
public class ActionNotHungry : ActionNodeAction
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
            if (_IACharacterVehicle.health is HealthAvispa)
            {
                if (((HealthAvispa)_IACharacterVehicle.health).hambre >= 70)
                {
                    return TaskStatus.Success;
                }
                else
                {
                    return TaskStatus.Failure;
                }
            }
            else
            {
                return TaskStatus.Failure;
            }
        }




        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction.health is HealthAvispa)
            {
                if (((HealthAvispa)_IACharacterAction.health).hambre >= 70)
                {
                    return TaskStatus.Success;
                }
                else
                {
                    return TaskStatus.Failure;
                }
            }
            else
            {
                return TaskStatus.Failure;
            }
        }

        return TaskStatus.Failure;
    }
}