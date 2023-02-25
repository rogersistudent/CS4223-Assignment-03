using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ExitHandler : MonoBehaviour
{

    public Text score;

    void Start()
    {
        score.text = PlayerPrefs.GetString("username") + ": " + PlayerPrefs.GetInt("highScore");
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        EditorApplication.isPlaying = false;
    }
}
