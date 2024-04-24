using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime;

[RequireComponent(typeof(BehaviorTree))]
public class IACharacterControl : MonoBehaviour
{
    //protected ThirdPersonCharacterAnimatorBase character;
    protected VisionSensor _AIEye;
    protected Health health;

    //public SoundCharacter SoundCharacterIA;

    public virtual void LoadComponent()
    {
        _AIEye = GetComponent<VisionSensor>();
        health = GetComponent<Health>();
    }
}
