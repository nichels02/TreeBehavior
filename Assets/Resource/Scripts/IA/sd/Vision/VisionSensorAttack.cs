using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionSensorAttack : VisionSensor
{
    [Space(100)]
    [Header("Main Vision de Ataque")]
    public DataViewBase MainVisionAttack = new DataViewBase();
    public DataViewBase MainVisionObject = new DataViewBase();
    public Health HealthAtaque;
    public item ElItem;
    // Start is called before the first frame update
    void Start()
    {
        LoadComponent();
    }

    // Update is called once per frame
    void Update()
    {
        if (Framerate > arrayRate[index])
        {
            MainVisionAttack.InSight = false;
            MainVision.InSight = false;
            index++;
            index = index % arrayRate.Length;
            Scan();
            ScanAtack();
            ScanObject();
            Framerate = 0;
        }
        Framerate += Time.deltaTime;
    }


    public override void Scan()
    {
        EnemyView = null;
        MainVision.InSight = false;
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, MainVision.distance, ScanLayerMask);

        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            Health Health = targetsInViewRadius[i].GetComponent<Health>();

            if (Health != null && MainVision.IsInSight(Health.AimOffset) && Health.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
            {
                EnemyView = Health;
            }
        }
    }
    public virtual void ScanAtack()
    {
        HealthAtaque = null;
        MainVisionAttack.InSight = false;
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, MainVisionAttack.distance, ScanLayerMask);

        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            Health Health = targetsInViewRadius[i].GetComponent<Health>();

            if (Health != null && MainVisionAttack.IsInSight(Health.AimOffset) && Health.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
            {
                HealthAtaque = Health;
            }
        }
    }

    public virtual void ScanObject()
    {
        ElItem = null;
        MainVisionAttack.InSight = false;
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, MainVisionAttack.distance, ScanLayerMask);

        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            item ElItemEncontrado = targetsInViewRadius[i].GetComponent<item>();

            if (ElItemEncontrado != null && MainVisionAttack.IsInSight(ElItemEncontrado.gameObject.transform) && ElItemEncontrado.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
            {
                ElItem = ElItemEncontrado;
            }
        }
    }


    private void OnValidate()
    {
        MainVision.CreateMesh();
        MainVisionAttack.CreateMesh();
        MainVisionObject.CreateMesh();
    }
    private void OnDrawGizmos()
    {
        MainVision.OnDrawGizmos();

        Gizmos.color = Color.red;
        if (EnemyView != null)
        {
            Gizmos.DrawLine(MainVision.Owner.AimOffset.position, EnemyView.AimOffset.position);
        }

        MainVisionAttack.OnDrawGizmos();

        Gizmos.color = Color.red;
        if (EnemyView != null)
        {
            Gizmos.DrawLine(MainVisionAttack.Owner.AimOffset.position, EnemyView.AimOffset.position);
        }

        MainVisionObject.OnDrawGizmos();

        Gizmos.color = Color.red;
        if (EnemyView != null)
        {
            Gizmos.DrawLine(MainVision.Owner.AimOffset.position, EnemyView.AimOffset.position);
        }

    }
}
