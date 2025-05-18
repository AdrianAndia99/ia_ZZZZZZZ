using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

public class Patrol : Action
{
    public Transform[] patrolPoints;
    private NavMeshAgent agent;
    private int currentPoint;

    public override void OnStart()
    {
        agent = GetComponent<NavMeshAgent>();
        if (patrolPoints.Length > 0)
        {
            agent.SetDestination(patrolPoints[0].position);
            currentPoint = 0;
        }
    }

    public override TaskStatus OnUpdate()
    {
        if (patrolPoints.Length == 0) return TaskStatus.Failure;

        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            currentPoint = (currentPoint + 1) % patrolPoints.Length;
            agent.SetDestination(patrolPoints[currentPoint].position);
        }

        return TaskStatus.Running;
    }
}