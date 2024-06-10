using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeCondicion/RangeHome")]
//NodoDeAccion
//NodoDeCondicion
public class ActionRangeHome : ActionNodeAction
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
            if (Vector3.Distance(_IACharacterVehicle.health.Hogar.position, _IACharacterVehicle.gameObject.transform.position) <= _IACharacterVehicle.agent.stoppingDistance)
            {
                return TaskStatus.Success;
            }
            else
            {
                return TaskStatus.Failure;
            }
        }




        return TaskStatus.Failure;
    }
}