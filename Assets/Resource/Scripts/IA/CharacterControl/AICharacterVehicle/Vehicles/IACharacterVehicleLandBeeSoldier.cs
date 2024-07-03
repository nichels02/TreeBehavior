using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterVehicleLandBeeSoldier : IACharacterVehicleLand
{
    [SerializeField] Vector3[] ListaDePatrullaje = new Vector3[1];
    int index;
    private void Start()
    {
        LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }

    public override void MoveToEnemy()
    {
        if (_AIVision.EnemyView == null)
            return;
        ViewToEnemy();

        MoveToPosition(_AIVision.EnemyView.transform.position, health.VelocidadMax / 2);
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
