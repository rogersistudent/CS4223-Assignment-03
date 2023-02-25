using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool gameHasEnded = false;

	public Rotator rotator;
	public Spawner spawner;

	public Animator animator;
    public GameObject pause;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale > 0)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        pause.SetActive(true);
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
    }

    public void EndGame ()
	{
		if (gameHasEnded)
			return;

		rotator.enabled = false;
		spawner.enabled = false;

		animator.SetTrigger("EndGame");

		gameHasEnded = true;
    }

	public void RestartLevel ()
	{
        int temp = PlayerPrefs.GetInt("lifes");
        temp--;
        PlayerPrefs.SetInt("lifes", temp);
        Debug.Log(temp);
        if(temp == 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
