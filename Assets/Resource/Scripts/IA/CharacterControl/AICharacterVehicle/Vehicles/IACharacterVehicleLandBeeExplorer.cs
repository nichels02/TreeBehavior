using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterVehicleLandBeeExplorer : IACharacterVehicleLandWander
{
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public override void MoveToPosition(Vector2 position)
    {
        base.MoveToPosition(position);
    }
    public override void Wander()
    {
        base.Wander();
    }

    public virtual void Evade(Vector2 PosicionEvadir, Vector2 PosicionActual, Vector2 PosicionDeseada)
    {
        float Distancia = Vector2.Distance(PosicionDeseada, PosicionActual);
        Distancia = Distancia > 5 ? Distancia : 6;
        Vector2 DireccionOpuesta = (PosicionActual - PosicionEvadir).normalized;
        DireccionOpuesta = PosicionActual + DireccionOpuesta * Distancia;

        Vector2 X = (DireccionOpuesta + PosicionActual) / 2;

        MoveToPosition(X);

    }
}
