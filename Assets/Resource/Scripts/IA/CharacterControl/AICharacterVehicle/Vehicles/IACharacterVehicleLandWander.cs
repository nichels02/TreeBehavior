using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterVehicleLandWander : IACharacterVehicleLand
{
    public Vector2 LimiteMax;
    public Vector2 LimiteMin;
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public override void MoveToPosition(Vector3 position)
    {
        base.MoveToPosition(position);
    }

    public override void Wander()
    {
        Vector3 i = new Vector3
        {
            x = Random.RandomRange(LimiteMin.x, LimiteMax.x) + transform.position.x,
            z = Random.RandomRange(LimiteMin.y, LimiteMax.y) + transform.position.z
        };
        MoveToPosition(i);
    }
    /*
    public override void Wander()
    {
        
    }
    */
}
