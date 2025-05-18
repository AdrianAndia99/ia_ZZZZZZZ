using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class IsTrue : Conditional
{
    public SharedBool variable;

    public override TaskStatus OnUpdate()
    {
        return variable.Value ? TaskStatus.Success : TaskStatus.Failure;
    }
}