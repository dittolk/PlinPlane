using System;
using UnityEngine;

public class Sound : MonoBehaviour
{
	private static Sound instance;
	
	public static Sound Instance
	{
		get
		{
			return Sound.instance;
		}
	}
	
	private void Awake()
	{
		if (Sound.instance != null && Sound.instance != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Sound.instance = this;
		if (Application.loadedLevel != 2)
		{
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
	
	private void Update()
	{
		if (Application.loadedLevel != 2)
		{
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
