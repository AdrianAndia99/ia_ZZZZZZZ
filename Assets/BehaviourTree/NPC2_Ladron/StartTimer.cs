using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class StartTimer : Action
{
    public SharedFloat timerDuration;
    private float endTime;

    public override void OnStart()
    {
        endTime = Time.time + timerDuration.Value;
    }

    public override TaskStatus OnUpdate()
    {
        return Time.time > endTime ? TaskStatus.Success : TaskStatus.Running;
    }
}