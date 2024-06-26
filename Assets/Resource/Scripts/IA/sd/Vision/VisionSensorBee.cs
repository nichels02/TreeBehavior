using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
 

public class VisionSensorBee : VisionSensor
{
    [Header("Resource View")]
    public Health ResourceView;
    private void Start()
    {
        LoadComponent();
    }
    public override void LoadComponent()
    {

        base.LoadComponent();
    }
    private void Update()
    {
        UpdateScand();
    }
    public override void UpdateScand()
    {
        if (Framerate > arrayRate[index])
        {
            index++;
            index = index % arrayRate.Length;
            this.Scan();
            Framerate = 0;
        }
        Framerate += Time.deltaTime;
    }
    public override void Scan()
    {
        EnemyView = null;
        AlliedView = null;
        ResourceView = null;
        MainVision.InSight = false;
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, MainVision.distance, ScanLayerMask);

        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            Health _health = targetsInViewRadius[i].GetComponent<Health>();

            if (_health != null && MainVision.IsInSight(_health.AimOffset) && _health.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
            {
                if (_health.MyUnitType == UnitType.Flor)
                {
                    ResourceView = _health;
                }
                else
                if (_health.MyUnitType == UnitType.Avispas)
                {

                    EnemyView = _health;
                }
                else
                if (_health.MyUnitType == UnitType.Abejas)
                {
                    AlliedView = _health;
                }
            }
        }
    }

    private void OnValidate()
    {
        MainVision.CreateMesh();
    }

    // Método para dibujar el radio de visión en el editor
    private void OnDrawGizmos()
    {
        MainVision.OnDrawGizmos();

        Gizmos.color = Color.red;
        if (EnemyView != null)
        {
            Gizmos.DrawLine(MainVision.Owner.AimOffset.position, EnemyView.AimOffset.position);
        }

    }
}

