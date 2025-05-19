using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEyeAttack : IAEyeBase
{
    public DataView AttackDataView = new DataView();
    
    public override void LoadComponent()
    {
        base.LoadComponent();
    }


    public override void UpdateScan()
    {
        base.UpdateScan();
        if (ViewThief != null)
            AttackDataView.IsInSight(ViewThief.AimOffset);
        else
        {
            AttackDataView.Sight = false;
            mainDataView.Sight = false;
            //RadioActionDataView.Sight = false;
        }

    }
     
}
