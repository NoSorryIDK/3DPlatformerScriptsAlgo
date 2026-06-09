using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportPoint.position;
    }
}
