using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;

    // Update is called once per frame
    void Update()
    {
        // update health bar
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;

        // update coins
        coinsCounterText.text = player.coins.ToString();
    }
}
