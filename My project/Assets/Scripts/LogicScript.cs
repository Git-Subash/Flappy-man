using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public static LogicScript instance;

    public GameObject GamerOverUI;
    public Text scoreText;
    int Score = 0;
void Awake()
    {
       instance = this; 
    } 
   
     void Start()
     {
        Score =0;
        scoreText.text = Score.ToString();
     }
    public void AddScore()
    {
        Score += 1;
        scoreText.text = Score.ToString();
    }
    
    public void Gameover()
    {
        GamerOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }
}
