using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
    public float restartdelay = 1f;
    public GameObject completelevelUI;
    public int currentlevel;
    public void LevelComplete()
    {
        completelevelUI.SetActive(true);
        currentlevel = SceneManager.GetActiveScene().buildIndex+1;
        PlayerPrefs.SetInt("Checkpoint", currentlevel);
    }
    public void EndGame()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            Invoke("RestartGame",restartdelay);
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
