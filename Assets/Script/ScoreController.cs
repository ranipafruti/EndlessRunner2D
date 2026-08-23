using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private TextMeshProUGUI currentScoreText;
   
    public static ScoreController instance;
    private static int score = 0;

    private void Awake()
    {
        instance = this;
       

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        //gameOverPanel.SetActive(true);
        GameManager.Instance.GameOver();
        if (currentScoreText != null)
            currentScoreText.text = "Score: " + score;

        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore = score;
        }

        if (highScoreText != null)
            highScoreText.text = "High Score: " + highScore;
    }
}
