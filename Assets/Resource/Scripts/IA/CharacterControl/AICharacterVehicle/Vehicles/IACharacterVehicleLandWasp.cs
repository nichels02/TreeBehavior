using System;
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
    public override void MoveToPosition(Vector3 position, float velocidad)
    {
        base.MoveToPosition(position, velocidad);
    }
    public override void Wander()
    {
        base.Wander();
        health.Velocidad = health.VelocidadMax;
    }

    public override void MoveToEnemy()
    {
        if (_AIVision.EnemyView == null)
            return;
        ViewToEnemy();

        #region variables
        float Distancia_Bajo;
        float Distancia_Medio;
        float Distancia_Alto;

        float hambre_Bajo;
        float hambre_Medio;
        float hambre_Alto;
        #endregion

        #region Hambre
        hambre_Bajo = Math.Max(0, Math.Min(1.0f, (23.0f - ((HealthAvispa)health).hambre) / 8.0f));
        hambre_Bajo *= 50;

        hambre_Medio = Math.Max(0f, Math.Min(1f, Math.Min((((HealthAvispa)health).hambre - 17.0f) / 8.0f, (42.0f - ((HealthAvispa)health).hambre) / 7.0f)));
        hambre_Medio *= 25;

        hambre_Alto = Math.Max(0, Math.Min(1.0f, (((HealthAvispa)health).hambre - 38f) / 5.0f));
        hambre_Alto *= 10;

        float HambreTotal = (hambre_Bajo + hambre_Medio + hambre_Alto)/ (10 + 25 + 50);
        #endregion

        #region Distancia

        float Distancia = Vector3.Distance(_AIVision.EnemyView.transform.position, transform.position);
        Distancia_Bajo = Math.Max(0f, Math.Min(1.0f, (7.0f - Distancia) / 4.0f));
        Distancia_Bajo *= 50;

        Distancia_Medio = Math.Max(0, Math.Min(1, Math.Min((Distancia - 5.0f) / 3.0f, (11.0f - Distancia) / 3.0f)));
        Distancia_Medio *= 25;

        Distancia_Alto = Math.Max(0, Math.Min(1.0f, (Distancia - 9f) / 5.0f));
        Distancia_Alto *= 10;

        float Distancia_Total = (Distancia_Bajo + Distancia_Medio + Distancia_Alto) / (10 + 25 + 50);
        #endregion

        health.Velocidad = health.VelocidadMax * ((HambreTotal + Distancia_Total));
        MoveToPosition(_AIVision.EnemyView.transform.position, health.Velocidad);
        //Predecir(3);
    }

    public virtual void Predecir(float tiempo)
    {
        IACharacterVehicleLand ElObjetivo = _AIVision.EnemyView.GetComponent<IACharacterVehicleLand>();
        Vector2 SuPosicion = new Vector2(ElObjetivo.gameObject.transform.position.x, ElObjetivo.gameObject.transform.position.y);
        Vector2 laDireccion = SuPosicion + (ElObjetivo.direccion * ElObjetivo._health.VelocidadMax / 2 * tiempo);
        MoveToPosition(laDireccion, health.Velocidad);
    }
}
