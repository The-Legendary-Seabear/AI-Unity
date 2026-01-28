using UnityEngine;

public class NavAgent : AIAgent
{
    [SerializeField] Movement movement;

    public NavNode TargetNode { get; set; } = null;

    void Start()
    {
        TargetNode = NavNode.GetRandomNavNode();
    }

    void Update()
    {
        if(TargetNode == null)
        {
            //Head - tail
            Vector3 direction = TargetNode.transform.position - transform.position;
            Vector3 force = direction.normalized * movement.maxForce;

            movement.ApplyForce(force);
        }
    }
}
