using UnityEngine;

public class Missile : MonoBehaviour
{
    private int speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other) 
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null) {
            Destroy(enemy.gameObject);
            Destroy(gameObject);
        }
    }
}
