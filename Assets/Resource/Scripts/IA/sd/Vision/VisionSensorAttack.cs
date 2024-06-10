using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionSensorAttack : VisionSensor
{
    [Space(100)]
    [Header("Main Vision de Ataque")]
    public DataViewBase MainVisionAttack = new DataViewBase();
    public Health HealthAtaque;
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
            Framerate = 0;
        }
        Framerate += Time.deltaTime;
    }


    public override void Scan()
    {
        base.Scan();
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



    private void OnValidate()
    {
        MainVision.CreateMesh();
        MainVisionAttack.CreateMesh();
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

    }
}
