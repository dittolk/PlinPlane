using System;
using UnityEngine;

public class SpawnPlatforms : MonoBehaviour
{
	private Vector2 originPosition;
	
	private Rigidbody2D x;
	
	private void Start()
	{
		this.x = base.GetComponent<Rigidbody2D>();
	}
	
	private void Update()
	{
		if (base.transform.localPosition.x < -9.28f)
		{
			base.transform.localPosition = new Vector3(-4.09f, base.transform.localPosition.y, base.transform.localPosition.z);
		}
		this.x.velocity = new Vector2(airplane.speed, 0f);
	}
}

