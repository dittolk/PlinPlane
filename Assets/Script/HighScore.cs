using System;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
	private int oldHighScore;
	
	private void Start()
	{
	}
	
	private void Update()
	{
		this.StoreHighscore(Score.score);
		base.GetComponent<Text>().text = string.Empty + this.oldHighScore;
		Message.message_score = this.oldHighScore;
	}
	
	private void StoreHighscore(int newHighscore)
	{
		this.oldHighScore = PlayerPrefs.GetInt("highscore", 0);
		if (newHighscore > this.oldHighScore)
		{
			PlayerPrefs.SetInt("highscore", newHighscore);
		}
	}
}
