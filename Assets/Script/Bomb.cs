using System;
using UnityEngine;

public class Bomb : MonoBehaviour
{
	public GameObject explofx;
	
	private void Start()
	{
	}
	
	private void Update()
	{
	}
	
	private void OnCollisionEnter2D(Collision2D other)
	{
		dropbomb.kena = false;
		if (other.gameObject.tag == "House")
		{
			Score.score++;
		}
		else if (other.gameObject.tag == "Box")
		{
			if (airplane.speed <= -4.5f)
			{
				airplane.speed += 0.4f;
			}
		}
		else if (other.gameObject.tag != "Plane" && other.gameObject.tag != "LandKosong")
		{
			dropbomb.losthealth = true;
		}
		UnityEngine.Object.Destroy(base.gameObject);
		if (other.gameObject.tag != "LandKosong" && other.gameObject.tag != "Batas" && other.gameObject.tag != "Plane")
		{
			UnityEngine.Object.Instantiate(this.explofx, base.transform.localPosition, base.transform.localRotation);
		}
	}
}
