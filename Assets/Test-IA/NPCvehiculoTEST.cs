using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

[TaskCategory("cubanoMRD")]
public class NPCvehiculoTEST : ActionNodeVehicle
{
    public override void OnStart()
    {
        base.OnStart();

        if (_IACharacterVehiculo == null)
        {
            Debug.LogError("NPCvehiculoWander: IACharacterVehiculo no encontrado en el GameObject.");
        }
    }

    public override TaskStatus OnUpdate()
    {
        if (_IACharacterVehiculo == null)
            return TaskStatus.Failure;

        _IACharacterVehiculo.MoveToWander();

        return TaskStatus.Running;
    }
}