using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterVehicleFly : IACharacterVehicle
{
    public float flightSpeed = 10f;
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public override void MoveToPositiononEvade()
    {
    }
    public override void MoveToPositiononWander(Vector3 position)
    {
        
    }
}