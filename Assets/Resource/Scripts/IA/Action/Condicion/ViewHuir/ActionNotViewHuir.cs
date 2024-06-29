using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion/ViewHuir")]

public class ActionNotViewHuir : ActionNodeAction
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
            if (_IACharacterVehicle._AIVision.EnemyView == null)
            {
                return TaskStatus.Success;
            }
            else if (_IACharacterVehicle._health.ElTipoDeHuida != _IACharacterVehicle._AIVision.EnemyView.ElTipoDeHuida)
            {
                return TaskStatus.Failure;
            }
        }
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction._AIVision.EnemyView == null)
            {
                return TaskStatus.Success;
            }
            else if (_IACharacterAction._health.ElTipoDeHuida != _IACharacterAction._AIVision.EnemyView.ElTipoDeHuida)
            {
                return TaskStatus.Failure;
            }
        }

        return TaskStatus.Failure;
    }
}
