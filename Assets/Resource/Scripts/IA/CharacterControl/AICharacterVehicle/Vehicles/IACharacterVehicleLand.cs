using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class IACharacterVehicleLand : IACharacterVehicle{
    
    public Vector2 direccion;
    public Vector2 PosicionPasada;
    public float Velocidad;
    public Vector3 RotacionAumentada;
    
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
            Vector2 PosicionActual = new Vector2(transform.position.x, transform.position.z); 
            Vector3 direction = PosicionActual - PosicionPasada;

            // Normaliza la dirección para obtener solo la dirección y no la distancia
            direccion = direction.normalized;

            // Actualiza la última posición
            PosicionPasada = PosicionActual;
        }
        else
        {
            PosicionPasada = new Vector2(transform.position.x, transform.position.z);
        }
    }

    public override void ViewToEnemy()
    {
        /*
        if (_AIVision.EnemyView == null) 
            return;

        //Vector2 direccion = (_AIVision.EnemyView.transform.position - transform.position).normalized;
        transform.rotation = Quaternion.LookRotation(_AIVision.EnemyView.transform.position);
        */
        // Calcula la dirección desde tu objeto hacia el enemigo
        Vector3 directionToEnemy = _AIVision.EnemyView.transform.position - transform.position;

        // Asegúrate de que la dirección no tenga un componente Y si quieres que la rotación solo afecte el plano XZ
        directionToEnemy.y = transform.rotation.y;

        // Crea la rotación que apunta hacia el enemigo
        Quaternion targetRotation = Quaternion.LookRotation(directionToEnemy);

        // Ajusta la rotación con 90 grados en el eje Y (puedes cambiar el valor si necesitas ajustar otro eje)
        Quaternion additionalRotation = Quaternion.Euler(RotacionAumentada);

        // Combina las dos rotaciones
        transform.rotation = targetRotation * additionalRotation;
    }

    public override void MoveToEnemy()
    {
        if (_AIVision.EnemyView == null)
            return;
        ViewToEnemy();



        MoveToPosition(_AIVision.EnemyView.transform.position, health.Velocidad);
    }

    public override void MoveToPosition(Vector3 position, float velocity)
    {
        agent.speed = velocity;
        agent.SetDestination(position);

        //if (this.agent.remainingDistance > this.agent.stoppingDistance)
        //{
        //    //(this.character).Move(this.agent.desiredVelocity);
        //    agent.isStopped = false;
        //}
        //else if (agent.destination == null)
        //{
        //    agent.SetDestination(position);
        //}
        //else
        //{
        //    //(this.character).Move(Vector3.zero);
        //    agent.SetDestination(position);
        //}

    }

    #endregion



}
