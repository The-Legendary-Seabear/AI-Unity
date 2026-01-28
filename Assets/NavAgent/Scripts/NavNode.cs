using UnityEngine;

public class NavNode : MonoBehaviour
{
    [SerializeField] protected NavNode[] neighbors;

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

    #endregion


}
