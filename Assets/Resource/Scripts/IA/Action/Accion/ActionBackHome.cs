using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeAccion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionBackHome : ActionNodeAction
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_IACharacterVehicle._health.IsDead)
        {
            return TaskStatus.Failure;
        }
        
        if(_IACharacterVehicle.agent!= _IACharacterVehicle._health.Hogar)
        {
            _IACharacterVehicle.MoveToPosition(_IACharacterVehicle._health.Hogar.position);
            return TaskStatus.Success;
        }
        else
        {
            return TaskStatus.Success;
        }
    }
}
