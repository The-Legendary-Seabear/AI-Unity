using UnityEngine;

[RequireComponent(typeof(NavPath))]
public class NavPathMovement : KinematicMovement
{
    NavPath navPath = null;
    public NavNode TargetNavNode { get; set; } = null;

    private void Awake()
    {
        navPath = GetComponent<NavPath>();
    }

    public override Vector3 Destination
    {
        get { return TargetNavNode.transform.position; }
        set { TargetNavNode = navPath.GeneratePath(transform.position, value); }
    }

    public void OnEnterNavNode(NavNode navNode)
    {
        if (navNode == TargetNavNode)
        {
            // get next nav node in path, returns null if no next
            TargetNavNode = navPath.GetNextNavNode(navNode);
        }
    }
}
