using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterVehicleLandBeeExplorer : IACharacterVehicleLandWander
{
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
        base.Wander();
    }
    public override void CalcularDireccion()
    {
        base.CalcularDireccion();
    }



    private void Update()
    {
        CalcularDireccion();
    }

    public override void MoveToPositiononEvade()
    {
        Evade(_AIVision.EnemyView.transform.position,/**/ transform.position,/**/ agent.destination);
    }

    public virtual void Evade(Vector3 PosicionEvadir, Vector3 PosicionActual, Vector3 PosicionDeseada)
    {
        float Distancia = Vector3.Distance(PosicionDeseada, PosicionActual);
        Distancia = Distancia > 5 ? Distancia : 6;
        Vector3 DireccionOpuesta = (PosicionActual - PosicionEvadir).normalized;
        DireccionOpuesta = PosicionActual + DireccionOpuesta * Distancia;

        Vector3 X = (DireccionOpuesta + PosicionActual) / 2;

        MoveToPosition(X);

    }
}
