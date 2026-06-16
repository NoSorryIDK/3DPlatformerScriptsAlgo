using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    public AudioSource audioSource;
    public AudioClip damageSound;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);

        if (health > 0) 
        {
            audioSource.PlayOneShot(damageSound);
        } 
        else 
        {
            // gets current level index and restarts it
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
