using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter(Collider other) 
    {
        SceneManager.LoadScene(sceneName);
    }
}
