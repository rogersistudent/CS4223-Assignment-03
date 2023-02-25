using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int PinCount;
	public Text playerName;
	public Text text;

	void Start ()
	{
		PinCount = 0;
		playerName.text = PlayerPrefs.GetString("username");
	}

	void Update ()
	{
		text.text = PinCount.ToString();
		if (PinCount > PlayerPrefs.GetInt("highScore"))
			PlayerPrefs.SetInt("highScore", PinCount);
	}

}
