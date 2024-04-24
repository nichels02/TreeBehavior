using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IACharacterVehicleLand : IACharacterVehicle{
    protected NavMeshAgent agent;

    public override void LoadComponent()
    {
        base.LoadComponent();
    }

    #region Move
    
    public override void MoveToPosition(Vector3 position)
    {
        agent.SetDestination(position);
        if (this.agent.remainingDistance > this.agent.stoppingDistance)
        {
            //(this.character).Move(this.agent.desiredVelocity);
        }
        else
        {
            //(this.character).Move(Vector3.zero);
        }
    }

    #endregion
}
