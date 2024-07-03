using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

[TaskCategory("IA SC/NodoDeAccion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionLlamarALosGuerreros : ActionNodeAction
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_IACharacterAction != null)
        {
            Debug.Log("Se reconocio el action");
            if (_IACharacterAction._health.IsDead)
            {
                Debug.Log("Esta muerto");
                return TaskStatus.Failure;
            }
        }

        if (_IACharacterAction != null)
        {
            Debug.Log("Esta muerto");
            if (_IACharacterAction is IACharacterActionLandBeeRecolector)
            {
                if (_IACharacterAction._health.FueAtacado)
                {
                    _IACharacterAction._health.FueAtacado = false;
                    ((IACharacterActionLandBeeRecolector)_IACharacterAction).LlamarALosGuerreros(_IACharacterAction._health.PosicionDondeAtacaron);
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

        return TaskStatus.Success;
    }

}