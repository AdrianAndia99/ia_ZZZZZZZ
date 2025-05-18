using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class CanSee : Conditional
{
    public SharedGameObject target;
    public float viewDistance = 10f;
    public float fieldOfView = 120f;

    public override TaskStatus OnUpdate()
    {
        if (target.Value == null) return TaskStatus.Failure;

        Vector3 direction = target.Value.transform.position - transform.position;
        float angle = Vector3.Angle(direction, transform.forward);

        if (direction.magnitude < viewDistance && angle < fieldOfView / 2)
        {
            Ray ray = new Ray(transform.position + Vector3.up, direction.normalized);
            if (Physics.Raycast(ray, out RaycastHit hit, viewDistance))
            {
                if (hit.collider.gameObject == target.Value)
                    return TaskStatus.Success;
            }
        }

        return TaskStatus.Failure;
    }
}