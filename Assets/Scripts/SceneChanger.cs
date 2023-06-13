using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName; // Nome da cena para carregar

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}

