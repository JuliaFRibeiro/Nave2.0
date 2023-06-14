using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string sceneName;
    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
