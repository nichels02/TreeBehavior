using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion/RangeAttack")]
//NodoDeAccion
//NodoDeCondicion
public class ActionRangeAttack : ActionNodeAction
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
        if (_IACharacterVehicle != null)
        {
            if (_IACharacterVehicle._AIVision.EnemyView != null)
            {
                if (_IACharacterVehicle._AIVision is VisionSensorAttack)
                {
                    if(((VisionSensorAttack)_IACharacterVehicle._AIVision).HealthAtaque != null)
                    {
                        if (_IACharacterVehicle._health.ElTipoDeEnemigo == ((VisionSensorAttack)_IACharacterVehicle._AIVision).HealthAtaque.MyUnitType)
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
            if (_IACharacterAction._AIVision.EnemyView != null)
            {
                if (_IACharacterAction._AIVision is VisionSensorAttack)
                {
                    if (((VisionSensorAttack)_IACharacterAction._AIVision).HealthAtaque != null)
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
            else
            {
                return TaskStatus.Failure;
            }
        }

        return TaskStatus.Failure;
    }
}