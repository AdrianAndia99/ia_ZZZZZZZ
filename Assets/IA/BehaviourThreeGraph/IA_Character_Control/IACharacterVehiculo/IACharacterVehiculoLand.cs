using UnityEngine;
using UnityEngine.AI;

public class IACharacterVehiculoLand : IACharacterVehiculo
{


    public override void LoadComponent()
    {
        base.LoadComponent();


        if (agent == null)
        {
            Debug.LogError("NavMeshAgent no encontrado en " + gameObject.name);
        }
    }

    public override void MoveToPosition(Vector3 pos)
    {
        if (agent != null && agent.isOnNavMesh)
        {
            agent.SetDestination(pos);
        }
    }

    public override void MoveToWander()
    {
        base.MoveToWander(); // reutiliza la lógica de wander
    }

    public override void MoveToEnemy()
    {
        base.MoveToEnemy();
    }

    public override void MoveToAllied()
    {
        base.MoveToAllied();
    }

    public override void MoveToEvadEnemy()
    {
        base.MoveToEvadEnemy();
    }
}
