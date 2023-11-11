using System;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
	public static int message_score;
	
	private void Start()
	{
		if (Message.message_score > 2 && Message.message_score <= 10)
		{
			base.GetComponent<Text>().text = "NOOB";
		}
		else if (Message.message_score > 10 && Message.message_score <= 20)
		{
			base.GetComponent<Text>().text = "NOT A BAD PLAYER";
		}
		else if (Message.message_score > 20 && Message.message_score <= 30)
		{
			base.GetComponent<Text>().text = "GOOD PLAYER";
		}
		else if (Message.message_score > 30 && Message.message_score <= 45)
		{
			base.GetComponent<Text>().text = "SUPER PlAYER";
		}
		else if (Message.message_score > 45 && Message.message_score <= 65)
		{
			base.GetComponent<Text>().text = "HANDSOME PlAYER";
		}
		else if (Message.message_score > 65 && Message.message_score <= 100)
		{
			base.GetComponent<Text>().text = "MASTER";
		}
		else if (Message.message_score > 100)
		{
			base.GetComponent<Text>().text = "LEGEND";
		}
		else
		{
			base.GetComponent<Text>().text = string.Empty;
		}
	}
	
	private void Update()
	{
	}
}
