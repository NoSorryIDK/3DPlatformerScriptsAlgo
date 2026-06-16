using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;
    public float curTemp = 36.6f;
    public float normTemp = 36.6f;
    public float critTemp = 34f;
    public float freezeSpeed = 0.05f;
    public int damageDone = 2;
    public float freezeDamageTimer = 1;
    public float freezeDamageDelay = 2;

    // Update is called once per frame
    void Update()
    {
        curTemp -= freezeSpeed * Time.deltaTime;

        if (curTemp <= critTemp)
        {
            if (freezeDamageTimer <= 0)
            {
                health.TakeDamage(damageDone);
                freezeDamageTimer += freezeDamageDelay;
            }
            else
            {
                freezeDamageTimer -= Time.deltaTime;
            }
        }
    }
}
