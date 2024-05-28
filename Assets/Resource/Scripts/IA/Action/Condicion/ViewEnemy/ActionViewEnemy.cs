using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion/ViewEnemy")]
//NodoDeAccion
//NodoDeCondicion
public class ActionViewEnemy : ActionNodeAction
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_IACharacterVehicle != null && _IACharacterVehicle.health.IsDead)
        {
            return TaskStatus.Failure;
        }
        else if (_IACharacterAction != null && _IACharacterAction.health.IsDead)
        {
            return TaskStatus.Failure;
        }
        if (_IACharacterVehicle != null)
        {
            if (_IACharacterVehicle._AIVision.EnemyView != null)
            {
                if(_IACharacterVehicle._AIVision.ElTipoDeEnemigo == _IACharacterVehicle._AIVision.EnemyView.UnitType)
                {
                    return TaskStatus.Success;
                }
            }
        }
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction._AIVision.EnemyView != null)
            {
                if (_IACharacterAction._AIVision.ElTipoDeEnemigo == _IACharacterAction._AIVision.EnemyView.UnitType)
                {
                    return TaskStatus.Success;
                }
            }
        }

        return TaskStatus.Failure;
    }
}
