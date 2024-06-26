using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion/ViewEnemy")]
//NodoDeAccion
//NodoDeCondicion
public class ActionNotViewEnemy : ActionNodeAction
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
            else if (_IACharacterVehicle._health.ElTipoDeEnemigo != _IACharacterVehicle._AIVision.EnemyView.MyUnitType)
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
            else if (_IACharacterAction._health.ElTipoDeEnemigo != _IACharacterAction._AIVision.EnemyView.MyUnitType)
            {
                return TaskStatus.Failure;
            }
        }

        return TaskStatus.Failure;
    }
}