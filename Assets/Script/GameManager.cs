using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;

    public static GameManager Instance;

    public bool isGameOver = false; 

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    { 
        isGameOver = true;

        if (gameOverPanel != null)

            gameOverPanel.SetActive(true);

                Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }
    public void HomeScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }

    public void StartSceneGame()
    {
        SceneManager.LoadScene("StartScene"); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
