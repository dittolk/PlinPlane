using System;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
	public static int game_over_score;
	
	private void Start()
	{
		base.GetComponent<Text>().text = string.Empty + GameOverScore.game_over_score;
	}
	
	private void Update()
	{

	}
}
