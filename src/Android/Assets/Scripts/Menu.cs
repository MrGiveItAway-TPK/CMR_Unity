using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int checkpoint;
    public Text continueGametext;
    public Dropdown dropDown;
    void Update()
    {
        continueGametext.text = "Checkpoint : Level " +PlayerPrefs.GetInt("Checkpoint").ToString();
        dropDown.value = PlayerPrefs.GetInt("QualitySetting");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SetQuality (int qualityindex)
    {
        QualitySettings.SetQualityLevel(qualityindex);
        PlayerPrefs.SetInt("QualitySetting", qualityindex);

    }

    public void ContinueGame()
    {
        checkpoint = PlayerPrefs.GetInt("Checkpoint");
        if (checkpoint > 0)
            SceneManager.LoadScene(checkpoint);
        else
            return;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
