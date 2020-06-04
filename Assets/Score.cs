using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    public int score, highScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI gameOverScoreText;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        score = 0; 
        highScore = 0;
        
    }
    public void AddScore()
    {
        score += 5;  
        scoreText.text = score.ToString();
        gameOverScoreText.text = score.ToString();
        UpdateHighScore();
    }
    public void UpdateHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            highScoreText.text = "High Score : " + highScore.ToString();
        }
    }
    public void ResetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
        gameOverScoreText.text = "Highest Score" + Environment.NewLine + score.ToString();
    }
}
