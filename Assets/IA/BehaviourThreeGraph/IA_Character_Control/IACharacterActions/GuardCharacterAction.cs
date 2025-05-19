using UnityEngine;

public class GuardCharacterAction : IACharacterActionsLand
{
    public override void LoadComponent()
    {
        base.LoadComponent();
        // Puedes inicializar aquí si necesitas otras referencias
    }

    public void ActPatrol()
    {
        // Lógica para patrullar (caminar en posiciones fijas o aleatorias)
        Debug.Log("El guardia patrulla.");
    }

    public void ActProtect()
    {
        if (AIEye.ViewAllie != null)
        {
            Debug.Log("El guardia protege al aliado.");
        }
    }

    public void ActChase()
    {
        if (AIEye.ViewThief != null)
        {
            Debug.Log("El guardia persigue al enemigo.");
        }
    }
}
