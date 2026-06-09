using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    public int coins;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);
    }

    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    public void CollectCoins()
    {
        coins++;
    }
}
