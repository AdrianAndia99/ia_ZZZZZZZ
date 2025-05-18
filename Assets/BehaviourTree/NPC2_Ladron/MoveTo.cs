using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

[RequireComponent(typeof(NavMeshAgent))]
public class MoveTo : Action
{
    public SharedGameObject targetObject;
    public float arriveDistance = 1f; // Distancia mínima para considerar "llegado"

    private NavMeshAgent agent;

    public override void OnStart()
    {
        agent = GetComponent<NavMeshAgent>();

        if (targetObject.Value != null)
        {
            agent.SetDestination(targetObject.Value.transform.position);
        }
    }

    public override TaskStatus OnUpdate()
    {
        if (targetObject.Value == null)
            return TaskStatus.Failure;

        float distance = Vector3.Distance(transform.position, targetObject.Value.transform.position);

        if (distance <= arriveDistance)
            return TaskStatus.Success;

        if (agent.pathPending || agent.remainingDistance > arriveDistance)
            return TaskStatus.Running;

        return TaskStatus.Success;
    }

    public override void OnEnd()
    {
        if (agent != null && !agent.pathPending)
        {
            agent.ResetPath();
        }
    }
}