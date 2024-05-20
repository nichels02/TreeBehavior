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
    public override void MoveToPosition(Vector2 position)
    {
        base.MoveToPosition(position);
    }

    public virtual void Wander()
    {
        Vector2 i = new Vector2
        {
            x = Random.RandomRange(LimiteMin.x, LimiteMax.x),
            y = Random.RandomRange(LimiteMin.y, LimiteMax.y)
        };
        MoveToPosition(i);
    }
}
