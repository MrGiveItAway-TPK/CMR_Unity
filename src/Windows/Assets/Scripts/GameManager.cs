using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
    public float restartdelay = 1f;
    public GameObject completelevelUI;
    public void LevelComplete()
    {
        completelevelUI.SetActive(true);
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
