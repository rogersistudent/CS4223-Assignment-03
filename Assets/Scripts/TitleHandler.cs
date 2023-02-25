using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleHandler : MonoBehaviour
{

    public Text playerName;
    public Slider rotatorSpeed;
    public Slider pinSpeed;
    public Dropdown rotatorColor;
    public Dropdown pinColor;
    public Text currentRotatorSpeed;
    public Text currentPinSpeed;

    void Update()
    {
        float tempspeed = pinSpeed.value * 5;
        currentRotatorSpeed.text = rotatorSpeed.value.ToString() + "%";
        currentPinSpeed.text = tempspeed.ToString() + "%";
    }

    public void StartGame()
    {
        PlayerPrefs.SetString("username", playerName.text);
        PlayerPrefs.SetFloat("rotatorSpeed", rotatorSpeed.value);
        PlayerPrefs.SetFloat("pinSpeed", pinSpeed.value);
        PlayerPrefs.SetInt("rotatorColor", rotatorColor.value);
        PlayerPrefs.SetInt("pinColor", pinColor.value);
        PlayerPrefs.SetInt("lifes", 3);
        PlayerPrefs.SetInt("highScore", 0);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
