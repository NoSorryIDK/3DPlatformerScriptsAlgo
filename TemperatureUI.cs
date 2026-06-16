using UnityEngine;
using TMPro;

public class TemperatureUI : MonoBehaviour
{
    public Temperature temperature;
    public TextMeshProUGUI tempText;

    // Update is called once per frame
    void Update()
    {
        float curTempDisplay = Mathf.Round(temperature.curTemp * 10.0f) * 0.1f;
        tempText.text = curTempDisplay.ToString();
    }
}
