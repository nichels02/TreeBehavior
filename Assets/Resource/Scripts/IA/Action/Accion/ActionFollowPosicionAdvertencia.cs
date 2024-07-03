using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeAccion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionFollowPosicionAdvertencia : ActionNodeAction
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
        if(_IACharacterVehicle != null)
        {
            if(_IACharacterVehicle._health is HealthSoldier)
            {
                _IACharacterVehicle.MoveToPosition(((HealthSoldier)_IACharacterVehicle._health).posicionAdvertida, _IACharacterVehicle._health.VelocidadMax / 2);
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
}