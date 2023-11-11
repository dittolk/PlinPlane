using System;
using UnityEngine;

public class OnBack : MonoBehaviour
{
	private void Start()
	{
	}
	
	private void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			if (Application.loadedLevelName == "about" || Application.loadedLevelName == "highscore" || Application.loadedLevelName == "gameover")
			{
				Application.LoadLevel("menu");
			}
			else if (Application.loadedLevelName == "credit")
			{
				Application.LoadLevel("about");
			}
			else if (Application.loadedLevelName == "howtoplay2")
			{
				Application.LoadLevel("howtoplay");
			}
			else if (Application.loadedLevelName == "menu")
			{
				Application.Quit();
			}
		}
	}
}
