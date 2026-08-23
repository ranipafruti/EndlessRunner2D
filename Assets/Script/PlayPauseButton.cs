using UnityEngine;
using UnityEngine.UI;

public class PlayPauseButton : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject playButton;

    private bool isPaused = false;

    public void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;

        pauseButton.SetActive(false);  // Pause button hide
        playButton.SetActive(true);   // Play button show
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;

        playButton.SetActive(false);  // Play button hide
        pauseButton.SetActive(true);  // Pause button show
    }
}
