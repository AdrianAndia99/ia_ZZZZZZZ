using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
public class IsInRestrictedArea : Conditional
{
    public SharedGameObject player;
    public LayerMask restrictedLayer;
    public override TaskStatus OnUpdate()
    {
        if (player.Value == null)
            return TaskStatus.Failure;

        Collider[] colliders = Physics.OverlapSphere(player.Value.transform.position, 0.1f, restrictedLayer);
        return colliders.Length > 0 ? TaskStatus.Success : TaskStatus.Failure;
    }
}