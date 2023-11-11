using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public static int score;
	
	private void Start()
	{
		Score.score = 0;
	}
	
	private void Update()
	{
		GetComponent<Text>().text = string.Empty + Score.score;
		GameOverScore.game_over_score = Score.score;
	}
}
