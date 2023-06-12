using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pnlGameOver;
    public TMP_Text txtScore;
    public TMP_Text txtLives;

    public GameObject fx;

    public GameObject Player;


    int Score = 0;
    int Lives = 3;

    private void Start()
    {
        txtScore.text = "0";
        txtLives.text = "3";
    }

    public void SetScore(int value)
    {
        Score += value;
        txtScore.text = Score.ToString();

    }

    public void SetSLives(int value)
    {
        Lives -= value;
        txtLives.text = Lives.ToString();

        if (Lives <= 0)
        {
            Instantiate(fx, transform.position, Quaternion.identity);
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