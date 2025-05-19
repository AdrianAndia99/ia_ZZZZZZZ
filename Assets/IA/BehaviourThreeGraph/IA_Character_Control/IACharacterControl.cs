using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class IACharacterControl : MonoBehaviour
{
    public NavMeshAgent agent { get; set; }
    public Health health { get; set; }
    public IAEyeBase AIEye { get; set; }

    public virtual void LoadComponent()
    {
        agent = GetComponent<NavMeshAgent>();
        Debug.Log("[IACharacterControl] agent: " + agent); // 👈 NUEVO
        health = GetComponent<Health>();
        AIEye = GetComponent<IAEyeBase>();
        if (agent == null) Debug.LogError("agent es null");
        if (health == null) Debug.LogError("health es null");
        if (AIEye == null) Debug.LogError("AIEye es null");
    }
}
