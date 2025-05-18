using System.Linq;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class FindClosest : Action
{
    public string tagToSearch = "Destructible";
    public SharedGameObject storeClosestObject;

    public override TaskStatus OnUpdate()
    {
        var objs = GameObject.FindGameObjectsWithTag(tagToSearch);
        if (objs.Length == 0) return TaskStatus.Failure;

        GameObject closest = objs.OrderBy(o => Vector3.Distance(o.transform.position, transform.position)).First();
        storeClosestObject.Value = closest;

        return TaskStatus.Success;
    }
}