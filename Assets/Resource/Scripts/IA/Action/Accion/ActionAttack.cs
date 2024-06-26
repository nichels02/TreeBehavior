using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[TaskCategory("IA SC/NodoDeAccion")]
//NodoDeAccion
//NodoDeCondicion
public class ActionAttack : ActionNodeAction
{
    bool YaPuedeAtacar=true;
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
        if (YaPuedeAtacar == true)
        {
            ((IACharacterActionLandAtack)_IACharacterAction).atack();
            StartCoroutine(Atacar());
        }
        
        return TaskStatus.Success;
    }

    IEnumerator Atacar()
    {
        YaPuedeAtacar = false;
        yield return new WaitForSeconds(1f);
        YaPuedeAtacar = true;
    }
}