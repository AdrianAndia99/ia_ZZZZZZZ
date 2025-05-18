using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;
public class PickupPackage : Action
{
    public SharedBool HasPackage;

    public override TaskStatus OnUpdate()
    {
        HasPackage.Value = true;
        // Aquí podrías reproducir una animación, sonido o activar un objeto visual
        return TaskStatus.Success;
    }
}