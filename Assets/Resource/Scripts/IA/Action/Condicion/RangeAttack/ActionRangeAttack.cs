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
    public float Distance;
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
            if (_IACharacterVehicle._AIVision.EnemyView != null)
            {
                if (Distance > Vector3.Distance(_IACharacterVehicle.transform.position, _IACharacterVehicle._AIVision.EnemyView.transform.position))
                {
                    return TaskStatus.Success;
                }
            }
        }
        else if (_IACharacterAction != null)
        {
            if (_IACharacterAction._AIVision.EnemyView != null)
            {
                if (Distance > Vector3.Distance(_IACharacterAction.transform.position, _IACharacterAction._AIVision.EnemyView.transform.position))
                {
                    return TaskStatus.Success;
                }
            }
        }

        return TaskStatus.Failure;
    }
}