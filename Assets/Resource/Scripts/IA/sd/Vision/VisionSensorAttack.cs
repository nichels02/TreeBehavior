using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionSensorAttack : VisionSensor
{
    [Space(100)]
    [Header("Main Vision de Ataque")]
    public DataViewBase MainVisionAttack = new DataViewBase();
    
    public Health HealthAtaque;
    public item ElItem;
    public item ElItemAtaque;
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
        EnemyView = null;
        MainVision.InSight = false;
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, MainVision.distance, ScanLayerMask);

        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            if (targetsInViewRadius[i].GetComponent<Health>())
            {
                Health _health = targetsInViewRadius[i].GetComponent<Health>();

                if (_health != null && MainVision.IsInSight(_health.AimOffset) && _health.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
                {
                    EnemyView = _health;
                }
            }
            else if (targetsInViewRadius[i].GetComponent<item>())
            {
                item elItem = targetsInViewRadius[i].GetComponent<item>();

                if (elItem != null && MainVision.IsInSight(elItem.transform) && elItem.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
                {
                    ElItem = elItem;
                }
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
            if (targetsInViewRadius[i].GetComponent<Health>())
            {
                Health _health = targetsInViewRadius[i].GetComponent<Health>();

                if (_health != null && MainVision.IsInSight(_health.AimOffset) && _health.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
                {
                    HealthAtaque = _health;
                }
            }
            else if (targetsInViewRadius[i].GetComponent<item>())
            {
                item elItem = targetsInViewRadius[i].GetComponent<item>();

                if (elItem != null && MainVision.IsInSight(elItem.transform) && elItem.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
                {
                    ElItemAtaque = elItem;
                }
            }
        }
    }
    /*
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
    */


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
