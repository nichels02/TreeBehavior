using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion/RangeItem")]

public class ActionNotRangeItem : ActionNodeAction
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
            if(_IACharacterVehicle._AIVision is VisionSensorAttack)
            {
                if (((VisionSensorAttack)_IACharacterVehicle._AIVision).ElItem != null)
                {
                    if (((VisionSensorAttack)_IACharacterVehicle._AIVision).ElItemAtaque == null)
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
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction._AIVision is VisionSensorAttack)
            {
                if (((VisionSensorAttack)_IACharacterAction._AIVision).ElItem != null)
                {
                    if (((VisionSensorAttack)_IACharacterAction._AIVision).ElItemAtaque == null)
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