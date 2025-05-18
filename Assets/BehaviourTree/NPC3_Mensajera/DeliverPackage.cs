using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class DeliverPackage : Action
{
    public SharedBool HasPackage;

    public override TaskStatus OnUpdate()
    {
        HasPackage.Value = false;
        // Aquí podrías mostrar feedback visual o sumar puntaje
        return TaskStatus.Success;
    }
}