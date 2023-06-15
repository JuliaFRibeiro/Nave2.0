using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pnlGameOver;
    
    public TMP_Text txtLives;

   

    public GameObject Player;


    
    int Lives = 3;

    public static UIManager instance;

    private void Start()
    {
        txtLives.text = "3";
    }

   

    public void SetSLives(int value)
    {
        Lives -= value;
        txtLives.text = Lives.ToString();

        if (Lives <= 0)
        {
            Destroy(Player.gameObject);
            GameOver();
        }
    }

    public void MyLoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void GameOver()
    {
        pnlGameOver.SetActive(true);
    }

}