using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }
}
