using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause_Menu : MonoBehaviour
{
    public Text pause;
    public GameObject pauseUI;
    public GameObject pauseButton;
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseUI.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void GoHome()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(false);
        pauseButton.SetActive(true);
    }
}
