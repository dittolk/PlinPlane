using System;
using UnityEngine;

public class airplane : MonoBehaviour
{
	public GameObject[] hati;
	
	public static int darah;
	
	public static int i;
	
	public static float speed;
	
	private int addspeed;
	
	private Rect move;
	
	private void Start()
	{
		airplane.darah = 3;
		airplane.i = 2;
		airplane.speed = -4.5f;
		addspeed = 5;
		move = new Rect(0f, 0f, (float)(Screen.width / 2), (float)Screen.height);
	}
	
	private void Update()
	{
		if (Input.touchCount > 0 && this.move.Contains(Input.GetTouch(0).position) && Input.GetTouch(0).phase == TouchPhase.Began)
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2((float)UnityEngine.Random.Range(10, 20), 0f);
			GetComponent<AudioSource>().Play();
		}
		if (dropbomb.losthealth)
		{
			UnityEngine.Object.Destroy(this.hati[airplane.i]);
			airplane.i--;
			airplane.darah--;
			dropbomb.losthealth = false;
		}
		if (airplane.darah == 0)
		{
			Application.LoadLevel(5);
		}
		if (addspeed == Score.score)
		{
			airplane.speed -= 0.8f;
			addspeed += 5;
		}
	}
}
