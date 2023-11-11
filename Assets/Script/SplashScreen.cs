using System;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
	private void Start()
	{
		base.Invoke("nextScene", 3f);
	}
	
	private void nextScene()
	{
		Application.LoadLevel("menu");
	}
}
