using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

namespace BehaviorDesigner.Runtime.Tasks.Tutorials
{
    [TaskCategory("Tutorial")]
    [TaskIcon("Assets/Behavior Designer Tutorials/Tasks/Editor/{SkinColor}SeekIcon.png")]
    public class Wander : Action
    {
        [Tooltip("The speed of the agent")]
        public SharedFloat speed = 3;
        [Tooltip("The angular speed of the agent")]
        public SharedFloat angularSpeed = 120;
        [Tooltip("The wander radius")]
        public SharedFloat wanderRadius = 10;
        [Tooltip("The minimum distance required to consider the destination reached")]
        public SharedFloat arriveDistance = 0.5f;

        private NavMeshAgent navMeshAgent;
        private Vector3 currentDestination;

        public override void OnAwake()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
        }

        public override void OnStart()
        {
            navMeshAgent.speed = speed.Value;
            navMeshAgent.angularSpeed = angularSpeed.Value;
            navMeshAgent.isStopped = false;

            SetNewDestination();
        }

        public override TaskStatus OnUpdate()
        {
            if (navMeshAgent.pathPending)
                return TaskStatus.Running;

            if (navMeshAgent.remainingDistance <= arriveDistance.Value)
            {
                SetNewDestination(); // Escoge un nuevo punto cuando llega
            }

            return TaskStatus.Running;
        }

        private void SetNewDestination()
        {
            Vector3 randomDirection = Random.insideUnitSphere * wanderRadius.Value;
            randomDirection += transform.position;

            NavMeshHit navHit;
            if (NavMesh.SamplePosition(randomDirection, out navHit, wanderRadius.Value, NavMesh.AllAreas))
            {
                currentDestination = navHit.position;
                navMeshAgent.SetDestination(currentDestination);
            }
        }

        public override void OnEnd()
        {
            navMeshAgent.isStopped = true;
        }

        public override void OnBehaviorComplete()
        {
            navMeshAgent.isStopped = true;
        }
    }
}