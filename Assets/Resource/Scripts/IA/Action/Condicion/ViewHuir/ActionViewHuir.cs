using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion/ViewHuir")]

public class ActionViewHuir : ActionNodeAction
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
            if (_IACharacterVehicle._AIVision.EnemyView != null)
            {
                if (_IACharacterVehicle._health.ElTipoDeHuida == _IACharacterVehicle._AIVision.EnemyView.ElTipoDeHuida)
                {
                    return TaskStatus.Success;
                }
            }
        }
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction._AIVision.EnemyView != null)
            {
                if (_IACharacterAction._health.ElTipoDeHuida == _IACharacterAction._AIVision.EnemyView.ElTipoDeHuida)
                {
                    return TaskStatus.Success;
                }
            }
        }

        return TaskStatus.Failure;
    }
}