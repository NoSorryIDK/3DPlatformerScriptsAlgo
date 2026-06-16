using UnityEngine;

public class FireballAttack : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;
    // object responsible for audio playback

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
