using System;
using UnityEngine;

public class dropbomb : MonoBehaviour
{
	public GameObject bom;
	
	public static bool kena;
	
	public static bool losthealth;
	
	private Rect boming;
	
	private void Awake()
	{
		dropbomb.kena = false;
		this.boming = new Rect((float)(Screen.width / 2), 0f, (float)(Screen.width / 2), (float)Screen.height);
	}
	
	private void Update()
	{
		if (Input.touchCount > 0 && this.boming.Contains(Input.GetTouch(0).position) && !dropbomb.kena)
		{
			UnityEngine.Object.Instantiate(this.bom, base.transform.position, base.transform.rotation);
			dropbomb.kena = true;
		}
	}
}
