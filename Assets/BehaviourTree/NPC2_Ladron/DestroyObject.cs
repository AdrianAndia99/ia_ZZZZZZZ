using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class DestroyObject : Action
{
    public SharedGameObject target;

    public override TaskStatus OnUpdate()
    {
        if (target.Value == null) return TaskStatus.Failure;

        GameObject.Destroy(target.Value);
        return TaskStatus.Success;
    }
}