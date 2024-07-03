using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/NodoDeAccion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionEvade : ActionNodeAction
{
    bool YaPuedeEvadir = true;
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
        if (YaPuedeEvadir == true)
        {
            _IACharacterVehicle.MoveToPositiononEvade();
            StartCoroutine(Evadir());
        }
        //SwitchMoveToAllied();
        return TaskStatus.Success;
    }


    IEnumerator Evadir()
    {
        YaPuedeEvadir = false;
        yield return new WaitForSeconds(5f);
        YaPuedeEvadir = true;
    }


}