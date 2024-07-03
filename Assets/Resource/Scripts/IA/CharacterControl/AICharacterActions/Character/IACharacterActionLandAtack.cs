using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterActionLandAtack : IACharacterActionLand
{
    public int damage;
    private void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
        

    }
    public override void atack()
    {
        print("entro al metodo de ataque");
        if (_AIVision is VisionSensorAttack /*&& ((VisionSensorAttack)_AIVision).MainVisionAttack.InSight*/)
        {
            print("es el sensor correcto");
            if (((VisionSensorAttack)_AIVision).HealthAtaque != null)
            {
                print("vio a alguien");
                if (((VisionSensorAttack)_AIVision).HealthAtaque.MyUnitType == health.ElTipoDeEnemigo)
                {
                    print("ataco");
                    if (((VisionSensorAttack)_AIVision).EnemyView.Damage(damage, _health))
                    {
                        print("lo mato");
                        LoMataste();
                    }
                }
                    
                
            }
        }

    }
    protected virtual void LoMataste()
    {

    }
}
