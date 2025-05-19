using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/View")]
public class ActionNodeNotViewThief : ActionNodeView
{
     

    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if(_IACharacterVehiculo.AIEye.ViewThief==null)
          return TaskStatus.Success;

        return TaskStatus.Failure;
    }


}