using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/BaseClass")]
public class ActionNode : Action
{

    protected IACharacterVehiculo _IACharacterVehiculo;
    protected IACharacterActions _IACharacterActions;
    protected UnitGame _UnitGame;
    public override void OnStart()
    {
        base.OnStart();
        _IACharacterVehiculo = GetComponent<IACharacterVehiculo>();
        _IACharacterActions = GetComponent<IACharacterActions>();
        _UnitGame = _IACharacterVehiculo.health._UnitGame;
        if(_IACharacterVehiculo.agent == null)
        {
            Debug.LogError("NavMeshAgent no encontrado en " + gameObject.name);
        }
        else
        {
            Debug.Log("carajo " + _IACharacterVehiculo.agent); // 👈 NUEVO
        }
    }


     
}