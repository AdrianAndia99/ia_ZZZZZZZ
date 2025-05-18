using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class GetNextPatrolPoint : Action
{
    public SharedGameObjectList patrolPoints;
    public SharedTransform currentTarget;
    private int currentIndex = -1;
    public override TaskStatus OnUpdate()
    {
        if (patrolPoints == null || patrolPoints.Value == null || patrolPoints.Value.Count == 0)
        {
            return TaskStatus.Failure;
        }

        currentIndex = (currentIndex + 1) % patrolPoints.Value.Count;
        currentTarget.Value = patrolPoints.Value[currentIndex].transform;

        return TaskStatus.Success;
    }
}