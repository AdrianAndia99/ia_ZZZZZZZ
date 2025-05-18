using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class Attack : Action
{
    public SharedGameObject target;

    public override TaskStatus OnUpdate()
    {
        if (target.Value == null) return TaskStatus.Failure;

        Debug.Log(gameObject.name + " ataca a " + target.Value.name);
        // Puedes llamar aquí a tu animación, lógica de daño, etc.

        return TaskStatus.Success;
    }
}