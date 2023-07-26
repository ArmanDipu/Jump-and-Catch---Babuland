using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    private float health = 3f;
    public Image[] hearts;

    public Sprite fullHeart;
    public Sprite emptyHeart;

    private float score = 0;
    public TextMeshProUGUI scoreText;

    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverScore;


    private void Update()
    {
        foreach (Image img in hearts)
        {
            img.sprite = emptyHeart;
        }
        for(int i = 0; i < health; i++) 
        {
            hearts[i].sprite = fullHeart;
        }
    }

    [ContextMenu("RedeuceHealth")]
    public void redeuceHealth()
    {
        health--;
        if(health == 0)
        {
            gameOver();
        }
    }

    [ContextMenu("AddScore")]
    public void addScore()
    {
        score++;
        scoreText.text = "Score : " + score.ToString();
    }

    void gameOver()
    {
        pauseGame();
        gameOverPanel.SetActive(true);
        gameOverScore.text = score.ToString();
    }
    
    public void pauseGame()
    {
        Time.timeScale = 0;
    }
    public void resumeGame()
    {
        Time.timeScale = 1;
    }

    public void continueGame()
    {
        health = 3;
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
