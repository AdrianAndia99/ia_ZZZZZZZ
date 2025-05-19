using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GuardCharacterVehicle : IACharacterVehiculo
{
    void Start()
    {
        print("[GuardCharacterVehicle] Start ejecutado.");
        //LoadComponent();
        this.LoadComponent();
        if (AIEye != null && AIEye.ViewEnemy != null) return;

    }

    public override void LoadComponent()
    {
        base.LoadComponent();
        //RangeWander = 10;
    }
    public override void MoveToPosition(Vector3 pos)
    {
        base.MoveToPosition(pos);
    }
    public void MovePatrol()
    {
        MoveToWander();
    }
    private void Update()
    {
        //MovePatrol();
    }
    public void MoveToEnemyPosition()
    {
        MoveToEnemy();
    }

    public void MoveToAlly()
    {
        MoveToAllied();
    }
}
