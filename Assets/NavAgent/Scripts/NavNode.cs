using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class NavNode : MonoBehaviour
{
    [SerializeField] protected List<NavNode> neighbors;

    public List<NavNode> Neighbors { get { return neighbors; } set { neighbors = value; } }

    private void OnTriggerEnter(Collider other)
    {
        //check if collider is nav agent
        if(other.gameObject.TryGetComponent<NavAgent>(out NavAgent navAgent))
        {
            navAgent.OnEnterNavNode(this);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //check if collider is nav agent
        if (other.gameObject.TryGetComponent<NavAgent>(out NavAgent navAgent))
        {
            navAgent.OnEnterNavNode(this);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        foreach(var neighbor in neighbors)
        {
            Gizmos.DrawLine(transform.position, neighbor.transform.position);
        }
    }

    #region helper_functions
    public static NavNode[] GetAllNavNodes()
    {
        return FindObjectsByType<NavNode>(FindObjectsSortMode.None);
    }

    public static NavNode GetRandomNavNode()
    {
        var navNodes = GetAllNavNodes();
        return (navNodes.Length == 0) ? null : navNodes[Random.Range(0, navNodes.Length)];
    }

    public static NavNode GetNearestNavNode(Vector3 position)
    {
        NavNode nearestNavNode = null;
        float nearestDistance = float.MaxValue;

        var navNodes = GetAllNavNodes();
        foreach(var navNode in navNodes)
        {
            float distance = Vector3.Distance(navNode.transform.position, position);
            if(distance < nearestDistance)
            {
                nearestNavNode = navNode;
                nearestDistance = distance;
            }
        }


        return nearestNavNode;
    }

    #endregion


}
