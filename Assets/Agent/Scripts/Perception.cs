using UnityEngine;

public abstract class Perception : MonoBehaviour
{
    [SerializeField] string info;

    [SerializeField] protected string tagName;
    [SerializeField] protected float maxDistance;
    [SerializeField] protected float maxAngle;

    public abstract GameObject[] GetGameObjects();
}
