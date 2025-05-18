using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class IsFalse : Conditional
{
    public SharedBool variable;

    public override TaskStatus OnUpdate()
    {
        return !variable.Value ? TaskStatus.Success : TaskStatus.Failure;
    }
}
