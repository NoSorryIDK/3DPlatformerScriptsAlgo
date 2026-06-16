using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public float burnTime = 15;
    public float heatTransfer = 0.1f;

    // Update is called once per frame
    void Update()
    {
        burnTime -= Time.deltaTime;

        if (burnTime <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Temperature>() != null)
        {
            Temperature temperature = other.GetComponent<Temperature>();

            if (temperature.curTemp < temperature.normTemp)
            {
                temperature.curTemp += heatTransfer * Time.deltaTime;
            }
        }
    }
}
