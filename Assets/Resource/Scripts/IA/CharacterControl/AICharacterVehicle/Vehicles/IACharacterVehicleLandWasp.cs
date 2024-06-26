using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterVehicleLandWasp : IACharacterVehicleLandWander
{
    private void Start()
    {
        LoadComponent();
    }
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

    public virtual void Predecir(IACharacterVehicleLand ElObjetivo, float tiempo)
    {
        Vector2 SuPosicion = new Vector2(ElObjetivo.gameObject.transform.position.x, ElObjetivo.gameObject.transform.position.y);
        Vector2 laDireccion = SuPosicion + (ElObjetivo.direccion * ElObjetivo.Velocidad * tiempo);
        MoveToPosition(laDireccion);
    }
}
