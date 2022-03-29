using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SetQuality (int qualityindex)
    {
        QualitySettings.SetQualityLevel(qualityindex);
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResulution(int resulutionindex)
    {
        if (resulutionindex == 0)
        {
            Screen.SetResolution(600, 400, false, 60);
        }
        if (resulutionindex == 1)
        {
            Screen.SetResolution(800, 600, false, 60);
        }
        if (resulutionindex == 2)
        {
            Screen.SetResolution(1280, 720, false, 60);
        }
        if (resulutionindex == 3)
        {
            Screen.SetResolution(1920, 1080, false, 60);
        }
    }
}
