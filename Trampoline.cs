using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // changes jump strength to 10
        other.GetComponent<Jump>().jumpStrength = 10;
    }

    void OnTriggerExit(Collider other)
    {
        // changes jump strength to 2
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
