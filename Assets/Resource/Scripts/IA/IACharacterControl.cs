using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime;

[RequireComponent(typeof(BehaviorTree))]
public class IACharacterControl : MonoBehaviour
{
    //protected ThirdPersonCharacterAnimatorBase character;
    public VisionSensor _AIVision;
    public Health health;
    public NavMeshAgent agent;

    public Health Health
    {
        get => health;
    }

    //public SoundCharacter SoundCharacterIA;

    public virtual void LoadComponent()
    {
        _AIVision = GetComponent<VisionSensor>();
        health = GetComponent<Health>();
        agent = GetComponent<NavMeshAgent>();
    }
}
