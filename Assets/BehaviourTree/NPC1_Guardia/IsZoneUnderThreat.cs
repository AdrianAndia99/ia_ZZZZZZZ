using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class IsZoneUnderThreat : Conditional
{
    public SharedTransform defensePoint;
    public float detectionRadius = 5f;
    public LayerMask enemyLayer;
    public override TaskStatus OnUpdate()
    {
        if (defensePoint.Value == null)
            return TaskStatus.Failure;

        Collider[] colliders = Physics.OverlapSphere(defensePoint.Value.position, detectionRadius, enemyLayer);
        return colliders.Length > 0 ? TaskStatus.Success : TaskStatus.Failure;
    }
}