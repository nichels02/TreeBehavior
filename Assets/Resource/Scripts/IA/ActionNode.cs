using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime.Tasks;




[TaskCategory("IA SC/Node Base")]
public class ActionNode : Action
{
    protected IACharacterAction _IACharacterAction;
    protected IACharacterVehicle _IACharacterVehicle;
    protected UnitType _UnitType;


    public override void OnStart()
    {
        _IACharacterVehicle = GetComponent<IACharacterVehicle>();
        if(_IACharacterVehicle == null)
        {
            Debug.LogWarning("Not load component IACharacterVehicle");
        }

        _IACharacterAction = GetComponent<IACharacterAction>();
        if (_IACharacterAction == null)
        {
            Debug.LogWarning("Not load component IACharacterAction");
        }

        if (_IACharacterVehicle != null)
        {
            _UnitType = this._IACharacterVehicle.Health.UnitType;
        }
       
    }
}
