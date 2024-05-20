using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class IACharacterVehicle : IACharacterControl
{
    public override void LoadComponent()
    {
        base.LoadComponent();   
    }
    #region Move
    public virtual void MoveToPositiononEvade()
    {

    }
    public virtual void MoveToPositiononWanderEnemy()
    {

    }
    public virtual void MoveToPositiononWander(Vector3 position)
    {
        
    }
    public virtual void MoveToPosition(Vector2 position)
    {

    }
    public virtual void MoveToAllied()
    {

    }
    public virtual void MoveToEnemy()
    {

    }
}
#endregion