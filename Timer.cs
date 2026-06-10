using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;

        if (seconds <= 0) 
        {
            if (minutes <= 0)
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
            else 
            {
                seconds += 59;
                minutes--;
            }
        }

        int roundSeconds = Mathf.RoundToInt(seconds);
        timeText.text = minutes + ":" + (roundSeconds < 10 ? "0" + roundSeconds : roundSeconds.ToString());
    }
}
