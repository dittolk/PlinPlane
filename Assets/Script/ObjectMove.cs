using System;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
	private Rigidbody2D moving;
	
	private void Start()
	{
		this.moving = base.GetComponent<Rigidbody2D>();
	}
	
	private void Update()
	{
		this.moving.velocity = new Vector2(airplane.speed, 0f);
		if (base.transform.localPosition.x < -9.5f)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
	
	private void OnCollisionEnter2D(Collision2D testing)
	{
		if (testing.gameObject.tag == "Bomb")
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
