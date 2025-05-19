using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/Move")]
public class ActionWander : ActionNodeVehicle
{
    public override void OnStart()
    {
        base.OnStart();
        Debug.Log("[ActionWander] OnStart ejecutado. Vehiculo: " + _IACharacterVehiculo);
    }
    public override TaskStatus OnUpdate()
    {
        Debug.Log("[ActionWander] OnUpdate ejecutado.");
        if (_IACharacterVehiculo.health.IsDead)
            return TaskStatus.Failure;

        SwitchUnit(); // Se ejecutará cada frame

        return TaskStatus.Success; // 👈 Hace que se siga ejecutando mientras esté activo
    }

    void SwitchUnit()
    {


        switch (_UnitGame)
        {
            case UnitGame.Guard:
                if(_IACharacterVehiculo is GuardCharacterVehicle)
                {
                    ((GuardCharacterVehicle)_IACharacterVehiculo).MovePatrol();
                    
                }

                break;
            case UnitGame.Soldier:
                if (_IACharacterVehiculo is IACharacterVehiculoSoldier)
                {
                    ((IACharacterVehiculoSoldier)_IACharacterVehiculo).MoveToWander();

                }
                break;
            case UnitGame.None:
                break;
            default:
                break;
        }



    }

}