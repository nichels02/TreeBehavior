using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

[TaskCategory("IA SC/NodoDeAccion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionGuardarAlmacenado : ActionNodeAction
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_IACharacterVehicle._health.IsDead || _IACharacterAction._health.IsDead)
        {
            return TaskStatus.Failure;
        }

        if (_IACharacterAction != null)
        {
            if (_IACharacterAction is IACharacterActionLandBeeRecolector)
            {
                ((IACharacterActionLandBeeRecolector)_IACharacterAction).Almacenar();
            }
            else
            {
                return TaskStatus.Failure;
            }
        }

        return TaskStatus.Success;
    }

}