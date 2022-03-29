using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    public Text leveltext;

    void Update()
    {
        scoretext.text = player.position.z.ToString("000");
        leveltext.text = " Level "+SceneManager.GetActiveScene().buildIndex.ToString();
    }
}
