using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    void Update() 
    {
        // changes NPC position to a new one every frame
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        
        // turns NPC each frame to face the target
        transform.LookAt(target.position);
    }

    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        player.TakeDamage(playerDamage);
    }
}
