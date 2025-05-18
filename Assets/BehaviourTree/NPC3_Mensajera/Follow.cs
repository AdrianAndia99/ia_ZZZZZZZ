using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

public class Follow : Action
{
    public SharedGameObject target;
    private NavMeshAgent agent;

    public float stoppingDistance = 2f;

    public override void OnStart()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.stoppingDistance = stoppingDistance;
    }

    public override TaskStatus OnUpdate()
    {
        if (target.Value == null)
            return TaskStatus.Failure;

        float distance = Vector3.Distance(transform.position, target.Value.transform.position);
        if (distance > stoppingDistance)
        {
            agent.SetDestination(target.Value.transform.position);
            return TaskStatus.Running;
        }
        else
        {
            agent.ResetPath();
            return TaskStatus.Success;
        }
    }
}