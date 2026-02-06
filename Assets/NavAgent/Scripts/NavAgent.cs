using UnityEngine;

public class NavAgent : AIAgent
{
    [SerializeField] Movement movement;

    public Vector3 Destination
    {
        get { return movement.Destination; }
        set { movement.Destination = value; }
    }












    //[SerializeField, Range(1,20)] float rotationRate = 1;
    //[SerializeField] NavPath navPath;

    //public NavNode TargetNode { get; set; } = null;

    //void Start()
    //{
    //    TargetNode = (navPath != null) ? 
    //        navPath.GeneratePath(transform.position, transform.position) : 
    //        NavNode.GetNearestNavNode(transform.position); ;
    //}

    //void Update()
    //{
    //    if(TargetNode != null)
    //    {
    //        //Head - tail
    //        Vector3 direction = TargetNode.transform.position - transform.position;
    //        Vector3 force = direction.normalized * movement.maxForce;

    //        movement.ApplyForce(force);
    //    }

    //    if(movement.Velocity.sqrMagnitude > 0)
    //    {
    //        //transform.LookAt(movement.Velocity);
    //        var targetRotation = Quaternion.LookRotation(movement.Velocity);
    //        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationRate * Time.deltaTime);
    //    }
    //}

    //public void OnEnterNavNode(NavNode navNode)
    //{
    //    if (navNode == TargetNode)
    //    {
    //        if (navPath != null) 
    //        {
    //            //get next nav node in path
    //            TargetNode = navPath.GetNextNavNode(navNode);
    //            if(TargetNode == null)
    //            {
    //                TargetNode = navPath.GeneratePath(navNode, NavNode.GetRandomNavNode());
    //            }
    //        }
    //        else
    //        {
    //            TargetNode = navNode.Neighbors[Random.Range(0, navNode.Neighbors.Count)];
    //        }
    //    }

    //}
}
