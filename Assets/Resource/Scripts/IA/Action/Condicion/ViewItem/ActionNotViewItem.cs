using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion/ViewItem")]

public class ActionNotViewItem : ActionNodeAction
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
            if (_IACharacterVehicle._AIVision is VisionSensorAttack)
            {
                if (((VisionSensorAttack)_IACharacterVehicle._AIVision).ElItem == null)
                {
                    return TaskStatus.Success;
                }
                else if (_IACharacterVehicle._health.ItemRecolectar != ((VisionSensorAttack)_IACharacterVehicle._AIVision).ElItem.MyUnitTypeObject)
                {
                    return TaskStatus.Success;
                }
            }
        }
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction._AIVision is VisionSensorAttack)
            {
                if (((VisionSensorAttack)_IACharacterAction._AIVision).ElItem == null)
                {
                    return TaskStatus.Success;
                }
                else if (_IACharacterAction._health.ItemRecolectar != ((VisionSensorAttack)_IACharacterAction._AIVision).ElItem.MyUnitTypeObject)
                {
                    return TaskStatus.Success;
                }
            }
        }

        return TaskStatus.Failure;
    }
}
