using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class IACharacterVehicleLand : IACharacterVehicle{
    
    public Vector2 direccion;
    public Vector2 PosicionPasada;
    public float Velocidad;
    
    public override void LoadComponent()
    {
        base.LoadComponent();
        agent.speed = Velocidad;
    }
    public override void Wander()
    {
        base.Wander();
    }
    #region Move
    public virtual void CalcularDireccion()
    {
        if (PosicionPasada != null)
        {
            Vector2 PosicionActual = new Vector2(transform.position.x, transform.position.y); 
            Vector3 direction = PosicionActual - PosicionPasada;

            // Normaliza la dirección para obtener solo la dirección y no la distancia
            direccion = direction.normalized;

            // Actualiza la última posición
            PosicionPasada = new Vector2(transform.position.x, transform.position.y);
        }
    }

    public override void ViewToEnemy()
    {
        if (_AIVision.EnemyView == null) 
            return;

        Vector2 direccion = (_AIVision.EnemyView.transform.position - transform.position).normalized;
        transform.rotation = Quaternion.LookRotation(direccion);
    }

    public override void MoveToEnemy()
    {
        if (_AIVision.EnemyView == null)
            return;
        ViewToEnemy();
        MoveToPosition(_AIVision.EnemyView.transform.position);
    }

    public override void MoveToPosition(Vector3 position)
    {
        
        if (this.agent.remainingDistance > this.agent.stoppingDistance)
        {
            //(this.character).Move(this.agent.desiredVelocity);
            agent.isStopped = false;
        }
        else if (agent.destination == null)
        {
            agent.SetDestination(position);
        }
        else
        {
            //(this.character).Move(Vector3.zero);
            agent.SetDestination(position);
        }

    }

    #endregion



}
