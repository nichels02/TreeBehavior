using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionSensorAttack : VisionSensor
{
    [Header("Main Vision de Ataque")]
    public DataViewBase MainVisionAttack = new DataViewBase();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyView != null)
            MainVisionAttack.IsInSight(EnemyView.AimOffset);
        else
            MainVisionAttack.InSight = false;
    }
}
