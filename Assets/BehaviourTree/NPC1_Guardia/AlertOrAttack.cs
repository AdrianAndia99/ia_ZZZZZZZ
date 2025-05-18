using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class AlertOrAttack : Action
{
    public SharedGameObject player;
    public override TaskStatus OnUpdate()
    {
        if (player.Value == null)
            return TaskStatus.Failure;

        Debug.Log("¡Intruso detectado! Atacando o alertando...");
        // Aquí podrías lanzar un evento de sonido, animación o combate

        return TaskStatus.Success;
    }
}