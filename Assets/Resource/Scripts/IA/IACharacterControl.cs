using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime;

[RequireComponent(typeof(BehaviorTree))]
public class IACharacterControl : MonoBehaviour
{
    //protected ThirdPersonCharacterAnimatorBase character;
    protected VisionSensor AIVision;
    protected Health health;
    protected NavMeshAgent _agent;

    public VisionSensor _AIVision { get => AIVision; set => AIVision = value; }
    
    public NavMeshAgent agent { get => _agent; set => _agent = value; }

    public Health _health
    {
        get => health;
        set => health = value;
    }

//public SoundCharacter SoundCharacterIA;

public virtual void LoadComponent()
    {
        _AIVision = GetComponent<VisionSensor>();
        _health = GetComponent<Health>();
        agent = GetComponent<NavMeshAgent>();
    }
}
