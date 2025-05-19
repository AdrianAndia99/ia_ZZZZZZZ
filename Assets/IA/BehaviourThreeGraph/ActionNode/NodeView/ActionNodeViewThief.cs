using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/View")]
public class ActionNodeViewThief : ActionNodeView
{
     

    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if(_IACharacterVehiculo.AIEye.ViewThief == null)
          return TaskStatus.Failure;

        return TaskStatus.Success;
    }


}