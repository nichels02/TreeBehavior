using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterVehicleLandBeeSoldier : IACharacterVehicleLand
{
    [SerializeField] Vector2[] ListaDePatrullaje = new Vector2[1];
    int index;
    public override void LoadComponent()
    {
        base.LoadComponent();
    }

    public override void MoveToPosition(Vector3 position, float Velocity)
    {
        base.MoveToPosition(position, Velocity);
    }

    public override void CalcularDireccion()
    {
        base.CalcularDireccion();
    }





    private void Update()
    {
        CalcularDireccion();
    }



    public virtual void Patrullaje()
    {
        if (index == ListaDePatrullaje.Length - 1)
        {
            index= 0;
        }
        else
        {
            index += 1;
        }
        MoveToPosition(ListaDePatrullaje[index], health.VelocidadMax / 2);
    }

}
